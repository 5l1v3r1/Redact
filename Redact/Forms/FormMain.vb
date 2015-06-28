Option Strict On
Imports System.Net
Imports System.Collections.Specialized
Imports System.Text
Imports System.Threading

Public Class FormMain
    Private _selectionStart As Point
    Private _selectionRect As New Rectangle
    Private ReadOnly _selectionBrush As New SolidBrush(Color.Black)

#Region "Uploader"
    Private Delegate Sub DelUpdateURL(Text As String)
    Private Sub UpdateURL(Text As String)
        If Me.InvokeRequired Then
            Me.Invoke(New DelUpdateURL(AddressOf UpdateURL), New Object() {Text})
        Else
            tslURL.Text = Text

            tspbUpload.Visible = False
            tslURL.Visible = True
        End If
    End Sub

    Private Function ImageToBase64(Image As Image) As String
        Dim ic As New ImageConverter
        Dim buffer As Byte() = DirectCast(ic.ConvertTo(Image, GetType(Byte())), Byte())

        Return Convert.ToBase64String(buffer, Base64FormattingOptions.InsertLineBreaks)
    End Function

    Private Sub UploadToImgur()
        Using wc As New WebClient
            wc.Headers.Add("Authorization", "Client-ID 8edc85d3fc5010d")
            Dim values As New NameValueCollection() From {{"image", ImageToBase64(pbMain.Image)}}

            Try
                Dim response As String = Split(Encoding.Default.GetString(wc.UploadValues("https://api.imgur.com/3/upload.xml", values)), "<link>").Last
                UpdateURL(response.Substring(0, response.IndexOf("<"c)))
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Redact | Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
    End Sub
#End Region

    Private Sub tsbUpload_Click(sender As Object, e As EventArgs) Handles tsbUpload.Click
        tslURL.Visible = False
        tspbUpload.Visible = True

        Dim uploadThread As New Thread(AddressOf UploadToImgur) With {.IsBackground = True}
        uploadThread.Start()
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        tslURL.Visible = False
        Using sfd As New SaveFileDialog With {.Title = "Redact | Save", .DefaultExt = ".png", .Filter = "PNG Image|*.png"}
            If sfd.ShowDialog() = DialogResult.OK Then

                Using bmp As New Bitmap(pbMain.Width, pbMain.Height)
                    pbMain.DrawToBitmap(bmp, pbMain.Bounds)
                    bmp.Save(sfd.FileName, Imaging.ImageFormat.Png)
                End Using

            End If
        End Using
    End Sub

    Private Sub tsb_Click(sender As Object, e As EventArgs) Handles tsbPixel.Click, tsbBlock.Click
        _selectionRect = Nothing
        For Each tsb As ToolStripButton In {tsbPixel, tsbBlock}
            tsb.Checked = (DirectCast(sender, ToolStripButton) Is tsb)
        Next

        Dim regionPoint As Point = PointToScreen(pbMain.Location)
        Dim regionShot As New Bitmap(pbMain.Width, (pbMain.Height - tsBottom.Height), Imaging.PixelFormat.Format32bppArgb)
        Dim graphic As Graphics = Graphics.FromImage(regionShot)

        graphic.CopyFromScreen(regionPoint.X, regionPoint.Y, 0, 0, pbMain.Size, CopyPixelOperation.SourceCopy)
        pbMain.Image = regionShot
        pbMain.BackColor = Color.FromKnownColor(KnownColor.Control)

        tsbUpload.Enabled = True
        tsbSave.Enabled = True
    End Sub

    Private Sub Form_Movement(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
        pbMain.BackColor = Color.Fuchsia
        pbMain.Image = Nothing

        _selectionRect = Nothing
    End Sub

    Private Sub pbMain_MouseDown(sender As Object, e As Windows.Forms.MouseEventArgs) Handles pbMain.MouseDown
        _selectionStart = e.Location
        pbMain.Invalidate()
    End Sub

    Private Sub pbMain_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs) Handles pbMain.MouseMove
        If Not e.Button.Equals(MouseButtons.Left) Then Return
        Dim tempEndPoint As Point = e.Location

        _selectionRect.Location = New Point(Math.Min(_selectionStart.X, tempEndPoint.X), Math.Min(_selectionStart.Y, tempEndPoint.Y))
        _selectionRect.Size = New Size(Math.Abs(_selectionStart.X - tempEndPoint.X), Math.Abs(_selectionStart.Y - tempEndPoint.Y))

        If tsbPixel.Checked Then pbMain.Image = Pixelate.Perform(New Bitmap(pbMain.Image), _selectionRect)

        pbMain.Invalidate()
    End Sub

    Private Sub pbMain_Paint(sender As Object, e As PaintEventArgs) Handles pbMain.Paint
        If tsbBlock.Checked AndAlso _selectionRect.Width > 0 AndAlso _selectionRect.Height > 0 Then
            e.Graphics.FillRectangle(_selectionBrush, _selectionRect)
        End If
    End Sub

    Private Sub tslURL_Click(sender As Object, e As EventArgs) Handles tslURL.Click
        Process.Start(tslURL.Text)
    End Sub
End Class