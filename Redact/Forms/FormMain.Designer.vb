<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.tsBottom = New System.Windows.Forms.ToolStrip()
        Me.tsbPixel = New System.Windows.Forms.ToolStripButton()
        Me.tsbBlock = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbUpload = New System.Windows.Forms.ToolStripButton()
        Me.tslURL = New System.Windows.Forms.ToolStripLabel()
        Me.tspbUpload = New System.Windows.Forms.ToolStripProgressBar()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbMain
        '
        Me.pbMain.BackColor = System.Drawing.Color.Fuchsia
        Me.pbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbMain.Location = New System.Drawing.Point(0, 0)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(493, 252)
        Me.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbMain.TabIndex = 0
        Me.pbMain.TabStop = False
        '
        'tsBottom
        '
        Me.tsBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsBottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbPixel, Me.tsbBlock, Me.tsbSave, Me.tsbUpload, Me.tslURL, Me.tspbUpload})
        Me.tsBottom.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsBottom.Location = New System.Drawing.Point(0, 227)
        Me.tsBottom.Name = "tsBottom"
        Me.tsBottom.Padding = New System.Windows.Forms.Padding(0)
        Me.tsBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBottom.Size = New System.Drawing.Size(493, 25)
        Me.tsBottom.TabIndex = 1
        '
        'tsbPixel
        '
        Me.tsbPixel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbPixel.Image = CType(resources.GetObject("tsbPixel.Image"), System.Drawing.Image)
        Me.tsbPixel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPixel.Name = "tsbPixel"
        Me.tsbPixel.Size = New System.Drawing.Size(51, 22)
        Me.tsbPixel.Text = "Pixelate"
        '
        'tsbBlock
        '
        Me.tsbBlock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBlock.Image = CType(resources.GetObject("tsbBlock.Image"), System.Drawing.Image)
        Me.tsbBlock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBlock.Name = "tsbBlock"
        Me.tsbBlock.Size = New System.Drawing.Size(40, 22)
        Me.tsbBlock.Text = "Block"
        '
        'tsbSave
        '
        Me.tsbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSave.Enabled = False
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(35, 22)
        Me.tsbSave.Text = "Save"
        '
        'tsbUpload
        '
        Me.tsbUpload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUpload.Enabled = False
        Me.tsbUpload.Image = CType(resources.GetObject("tsbUpload.Image"), System.Drawing.Image)
        Me.tsbUpload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpload.Name = "tsbUpload"
        Me.tsbUpload.Size = New System.Drawing.Size(49, 22)
        Me.tsbUpload.Text = "Upload"
        '
        'tslURL
        '
        Me.tslURL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslURL.IsLink = True
        Me.tslURL.Name = "tslURL"
        Me.tslURL.Size = New System.Drawing.Size(0, 22)
        Me.tslURL.Visible = False
        '
        'tspbUpload
        '
        Me.tspbUpload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tspbUpload.MarqueeAnimationSpeed = 120
        Me.tspbUpload.Name = "tspbUpload"
        Me.tspbUpload.Size = New System.Drawing.Size(140, 22)
        Me.tspbUpload.Step = 40
        Me.tspbUpload.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.tspbUpload.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 252)
        Me.Controls.Add(Me.tsBottom)
        Me.Controls.Add(Me.pbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Redact"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBottom.ResumeLayout(False)
        Me.tsBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbMain As System.Windows.Forms.PictureBox
    Friend WithEvents tsBottom As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbUpload As System.Windows.Forms.ToolStripButton
    Friend WithEvents tslURL As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tspbUpload As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tsbPixel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBlock As System.Windows.Forms.ToolStripButton

End Class
