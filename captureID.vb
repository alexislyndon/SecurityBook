Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure
Imports System.IO

Public Class captureID
    Dim front = String.Format("D:\secu\F_{0:yyyyMMddHHmmss}.jpg", Date.Now)
    Dim back = String.Format("D:\secu\B_{0:yyyyMMddHHmmss}.jpg", Date.Now)
    Dim avobj As AddVisitor
    Dim rotated As Boolean = False
    Public Sub New(av As AddVisitor)
        cap.FlipHorizontal = True
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 320) '337
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 240) '212
        avobj = av
        InitializeComponent()
        Timer1.Start()
    End Sub
    Dim cap As New Capture() 'first line

    Private Sub capturepic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Freeze.Click
        If Not rotated Then
            rotate()
        End If
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try

            PictureBox1.Image = cap.QueryFrame.ToBitmap() 'Second line
        Catch ex As Exception
            MsgBox("There was an unexpected error. Please restart the application.")
            Timer1.Stop()
            Me.Close()
        End Try
        'Label1.Text = Date.Now.ToString("yyyy:MMM:dd:hh:mm:ss")
    End Sub

    Private Sub StartCapture(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unfreeze.Click
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cap.FlipHorizontal = True
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 320) '424
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 240) '240 337, 212
    End Sub

    Private Sub Front_Click(sender As Object, e As EventArgs) Handles Frontbtn.Click 'Front
        'PictureBox1.Image.Save(front, Imaging.ImageFormat.Jpeg)
        PictureBox2.Image = PictureBox1.Image
        PictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)

        avobj.hadcapid = True
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Backbtn.Click 'Back
        'PictureBox1.Image.Save(back, Imaging.ImageFormat.Jpeg)
        PictureBox3.Image = PictureBox1.Image
        PictureBox3.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        avobj.hadcapback = True
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles Save.Click
        avobj.setidpic(PictureBox2.Image)
        avobj.setidback(PictureBox3.Image)
        cap.Dispose()
        Me.Dispose()
    End Sub

    Private Sub rotate()
        If Not rotated Then
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            rotated = True
        End If
    End Sub

    Private Sub closelbl_Click(sender As Object, e As EventArgs) Handles closelbl.Click
        Me.Close()
    End Sub
End Class