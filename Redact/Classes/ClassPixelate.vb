Option Strict On

Public Class Pixelate
    Public Shared Function Perform(Input As Bitmap, Area As Rectangle) As Bitmap
        Const cell As Integer = 6
        Dim x As Integer = Area.X
        Dim y As Integer = Area.Y
        Dim bmp As New Bitmap(Input)
        Using graphic As Graphics = Graphics.FromImage(bmp)

            Dim x1 As Integer = cell * Convert.ToInt32(x \ cell)
            While x1 <= x + Area.Width
                Dim y1 As Integer = cell * Convert.ToInt32(y \ cell)
                While y1 <= y + Area.Height
                    Dim avgColor As Color = AverageRectangle(Input, x1, y1, cell, cell)

                    Using solidBrush As New SolidBrush(avgColor)
                        graphic.FillRectangle(solidBrush, x1, y1, cell, cell)
                    End Using
                    y1 += cell
                End While
                x1 += cell
            End While
        End Using

        Return bmp
    End Function

    Private Shared Function AverageRectangle(Input As Bitmap, x As Integer, y As Integer, Width As Integer, Height As Integer) As Color
        If x < 0 Then x = 0
        If x + Width >= Input.Width Then Width = Input.Width - x - 1

        If y < 0 Then y = 0
        If y + Height >= Input.Height Then Height = Input.Height - y - 1

        If Width <= 0 Or Height <= 0 Then Return Color.Black

        Dim clr As Color
        Dim r As Integer = 0, g As Integer = 0, b As Integer = 0
        For i As Integer = 0 To Height - 1
            For j As Integer = 0 To Width - 1
                clr = Input.GetPixel(x + j, y + i)
                r += clr.R
                g += clr.G
                b += clr.B
            Next
        Next

        r = Convert.ToInt32(r / (Width * Height))
        g = Convert.ToInt32(g / (Width * Height))
        b = Convert.ToInt32(b / (Width * Height))

        Return Color.FromArgb(255, r, g, b)
    End Function
End Class