Public Class Form1
    Dim rs As New InputResizer
    Dim TLine4 As Integer = 1
    Dim TLine5 As Integer = 1
    Dim TLine6 As Integer = 1
    Dim BLine4 As Integer = 1
    Dim BLine5 As Integer = 1
    Dim BLine6 As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub ButtonSubmit(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Form2.TextBox1.Text = TextBox1.Text
        Form2.TextBox3.Text = TextBox33.Text
        Form2.TextBox8.Text = TextBox34.Text
        Form2.TextBox5.Text = TextBox35.Text
        Form2.TextBox2.Text = TextBox6.Text
        Form2.TextBox6.Text = TextBox11.Text
        Form2.TextBox7.Text = TextBox12.Text
        Form2.TextBox10.Text = TextBox13.Text
        Form2.TextBox11.Text = TextBox17.Text
        Form2.TextBox71.Text = TextBox16.Text
        Form2.TextBox79.Text = TextBox15.Text
        Form2.TextBox45.Text = TextBox3.Text
        Form2.TextBox69.Text = TextBox22.Text
        Form2.TextBox70.Text = TextBox2.Text
        Form2.TextBox39.Text = TextBox38.Text
        Form2.TextBox38.Text = TextBox39.Text
        Form2.TextBox40.Text = TextBox40.Text
        Form2.TextBox12.Text = TextBox10.Text
        Form2.TextBox16.Text = TextBox9.Text
        Form2.TextBox17.Text = TextBox8.Text
        Form2.TextBox22.Text = TextBox20.Text
        Form2.TextBox78.Text = TextBox19.Text
        Form2.TextBox86.Text = TextBox18.Text
        Form2.TextBox52.Text = TextBox4.Text
        Form2.TextBox44.Text = TextBox44.Text
        Form2.TextBox4.Text = TextBox7.Text
        Form2.TextBox21.Text = TextBox21.Text
        Form2.TextBox30.Text = TextBox24.Text
        Form2.TextBox20.Text = TextBox14.Text
        Form2.TextBox29.Text = TextBox23.Text
        Form2.TextBox37.Text = TextBox25.Text
        Form2.TextBox9.Text = TextBox26.Text
        Form2.TextBox13.Text = TextBox27.Text
        Form2.Label1.Text = ComboBox1.Text
        Form2.Label2.Text = ComboBox2.Text
        Form2.Label3.Text = ComboBox3.Text
        Form2.Label4.Text = ComboBox4.Text
        Form2.Label5.Text = ComboBox5.Text
        Form2.Label6.Text = ComboBox6.Text
        Form2.Label7.Text = ComboBox7.Text
        Form2.Label8.Text = ComboBox8.Text
        Form2.Label9.Text = ComboBox9.Text
        Form2.Label10.Text = ComboBox10.Text
        Form2.Label11.Text = ComboBox11.Text
        Form2.Label12.Text = ComboBox12.Text
        Form2.Label13.Text = ComboBox13.Text
        Form2.Label14.Text = ComboBox14.Text
        Form2.Label15.Text = ComboBox15.Text
        Form2.Label16.Text = ComboBox16.Text
        Form2.Label17.Text = ComboBox17.Text
        Form2.Label18.Text = ComboBox18.Text
        Form2.Label19.Text = ComboBox19.Text
        Form2.Label20.Text = ComboBox20.Text
        Form2.Label21.Text = ComboBox21.Text
        Form2.Label22.Text = ComboBox22.Text
        Form2.Label23.Text = ComboBox23.Text
        Form2.Label24.Text = ComboBox24.Text
        Form2.Label25.Text = ComboBox25.Text
        Form2.Label26.Text = ComboBox26.Text
        Form2.Label27.Text = ComboBox27.Text
        Form2.Label28.Text = ComboBox28.Text
        Form2.Label29.Text = ComboBox29.Text
        Form2.Label30.Text = ComboBox30.Text
        Form2.Label31.Text = ComboBox31.Text
        Form2.Label32.Text = ComboBox32.Text
        Form2.Label33.Text = ComboBox33.Text
        Form2.Label34.Text = ComboBox34.Text
        Form2.Label35.Text = ComboBox35.Text
        Form2.Label36.Text = ComboBox36.Text
        Form2.Label37.Text = ComboBox37.Text
        Form2.Label38.Text = ComboBox38.Text
        Form2.Label39.Text = ComboBox39.Text
        Form2.Label40.Text = ComboBox40.Text
        Form2.Label41.Text = ComboBox41.Text
        Form2.Label42.Text = ComboBox42.Text
        Form2.Label43.Text = ComboBox43.Text
        Form2.Label44.Text = ComboBox44.Text
        Form2.Label45.Text = ComboBox45.Text
        Form2.Label46.Text = ComboBox46.Text
        Form2.Label47.Text = ComboBox47.Text
        Form2.Label48.Text = ComboBox48.Text
        Form2.Label49.Text = ComboBox49.Text
        Form2.Label50.Text = ComboBox50.Text
        Form2.Label51.Text = ComboBox51.Text
        Form2.Label52.Text = ComboBox52.Text
        Form2.Label53.Text = ComboBox53.Text
        Form2.Label54.Text = ComboBox54.Text
        Form2.Label55.Text = ComboBox55.Text
        Form2.Label56.Text = ComboBox56.Text
        Form2.Label57.Text = ComboBox57.Text
        Form2.Label58.Text = ComboBox58.Text
        Form2.Label59.Text = ComboBox59.Text
        Form2.Label60.Text = ComboBox60.Text
        Form2.Label61.Text = ComboBox61.Text
        Form2.Label62.Text = ComboBox62.Text
        Form2.Label63.Text = ComboBox63.Text
        Form2.Label64.Text = ComboBox64.Text
        Form2.Label65.Text = ComboBox65.Text
        Form2.Label66.Text = ComboBox66.Text
        Form2.Label67.Text = ComboBox67.Text
        Form2.Label68.Text = ComboBox68.Text
        Form2.Label69.Text = ComboBox69.Text
        Form2.Label70.Text = ComboBox70.Text
        Form2.Label71.Text = ComboBox71.Text
        Form2.Label72.Text = ComboBox72.Text
        Form2.Label73.Text = ComboBox73.Text
        Form2.Label74.Text = ComboBox74.Text
        Form2.Label75.Text = ComboBox75.Text
        Form2.Label76.Text = ComboBox76.Text
        Form2.Label77.Text = ComboBox77.Text
        Form2.Label78.Text = ComboBox78.Text
        Form2.Label79.Text = ComboBox79.Text
        Form2.Label80.Text = ComboBox80.Text
        Form2.Label81.Text = ComboBox81.Text
        Form2.Label82.Text = ComboBox82.Text
        Form2.Label83.Text = ComboBox83.Text
        Form2.Label84.Text = ComboBox84.Text
    End Sub

    Private Sub ButtonClear(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "POOL A"
        TextBox33.Text = "Player 1"
        TextBox34.Text = "Player 2"
        TextBox35.Text = "Player 3"
        TextBox6.Text = "POOL B"
        TextBox11.Text = "Player 1"
        TextBox12.Text = "Player 2"
        TextBox13.Text = "Player 3"
        TextBox17.Text = "Player 4"
        TextBox16.Text = "Player 5"
        TextBox15.Text = "Player 6"
        TextBox3.Text = "Player A"
        TextBox22.Text = "DAN MENS CATEGORY"
        TextBox2.Text = "Shiaijo A"
        TextBox38.Text = "Player 1"
        TextBox39.Text = "Player 2"
        TextBox40.Text = "Player 3"
        TextBox10.Text = "Player 1"
        TextBox9.Text = "Player 2"
        TextBox8.Text = "Player 3"
        TextBox20.Text = "Player 4"
        TextBox19.Text = "Player 5"
        TextBox18.Text = "Player 6"
        TextBox4.Text = "Player B"
        TextBox44.Text = "POOL A AND POOL B"
        TextBox7.Text = "Player 4"
        TextBox21.Text = "Player 5"
        TextBox24.Text = "Player 6"
        TextBox14.Text = "Player 4"
        TextBox23.Text = "Player 5"
        TextBox25.Text = "Player 6"
        TextBox26.Text = "Player A"
        TextBox27.Text = "Player B"
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        ComboBox10.Text = ""
        ComboBox11.Text = ""
        ComboBox12.Text = ""
        ComboBox13.Text = ""
        ComboBox14.Text = ""
        ComboBox15.Text = ""
        ComboBox16.Text = ""
        ComboBox17.Text = ""
        ComboBox18.Text = ""
        ComboBox19.Text = ""
        ComboBox20.Text = ""
        ComboBox21.Text = ""
        ComboBox22.Text = ""
        ComboBox23.Text = ""
        ComboBox24.Text = ""
        ComboBox25.Text = ""
        ComboBox26.Text = ""
        ComboBox27.Text = ""
        ComboBox28.Text = ""
        ComboBox29.Text = ""
        ComboBox30.Text = ""
        ComboBox31.Text = ""
        ComboBox32.Text = ""
        ComboBox33.Text = ""
        ComboBox34.Text = ""
        ComboBox35.Text = ""
        ComboBox36.Text = ""
        ComboBox37.Text = ""
        ComboBox38.Text = ""
        ComboBox39.Text = ""
        ComboBox40.Text = ""
        ComboBox41.Text = ""
        ComboBox42.Text = ""
        ComboBox43.Text = ""
        ComboBox44.Text = ""
        ComboBox45.Text = ""
        ComboBox46.Text = ""
        ComboBox47.Text = ""
        ComboBox48.Text = ""
        ComboBox49.Text = ""
        ComboBox50.Text = ""
        ComboBox51.Text = ""
        ComboBox52.Text = ""
        ComboBox53.Text = ""
        ComboBox54.Text = ""
        ComboBox55.Text = ""
        ComboBox56.Text = ""
        ComboBox57.Text = ""
        ComboBox58.Text = ""
        ComboBox59.Text = ""
        ComboBox60.Text = ""
        ComboBox61.Text = ""
        ComboBox62.Text = ""
        ComboBox63.Text = ""
        ComboBox64.Text = ""
        ComboBox65.Text = ""
        ComboBox66.Text = ""
        ComboBox67.Text = ""
        ComboBox68.Text = ""
        ComboBox69.Text = ""
        ComboBox70.Text = ""
        ComboBox71.Text = ""
        ComboBox72.Text = ""
        ComboBox73.Text = ""
        ComboBox74.Text = ""
        ComboBox75.Text = ""
        ComboBox76.Text = ""
        ComboBox77.Text = ""
        ComboBox78.Text = ""
        ComboBox79.Text = ""
        ComboBox80.Text = ""
        ComboBox81.Text = ""
        ComboBox82.Text = ""
        ComboBox83.Text = ""
        ComboBox84.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.TextBox4.Show()
        Form2.TextBox20.Show()
        Form2.Label19.Show()
        Form2.Label20.Show()
        Form2.Label21.Show()
        Form2.Label22.Show()
        Form2.Label23.Show()
        Form2.Label24.Show()
        TLine4 = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TLine4 = 1 Then
            Form2.TextBox21.Show()
            Form2.TextBox29.Show()
            Form2.Label25.Show()
            Form2.Label26.Show()
            Form2.Label27.Show()
            Form2.Label28.Show()
            Form2.Label29.Show()
            Form2.Label30.Show()
            TLine5 = 1
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TLine5 = 1 Then
            Form2.TextBox30.Show()
            Form2.TextBox37.Show()
            Form2.Label31.Show()
            Form2.Label32.Show()
            Form2.Label33.Show()
            Form2.Label34.Show()
            Form2.Label35.Show()
            Form2.Label36.Show()
            TLine6 = 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TLine5 = 0 Then
            Form2.TextBox4.Hide()
            Form2.TextBox20.Hide()
            Form2.Label19.Hide()
            Form2.Label20.Hide()
            Form2.Label21.Hide()
            Form2.Label22.Hide()
            Form2.Label23.Hide()
            Form2.Label24.Hide()
            TLine4 = 0
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TLine6 = 0 Then
            Form2.TextBox21.Hide()
            Form2.TextBox29.Hide()
            Form2.Label25.Hide()
            Form2.Label26.Hide()
            Form2.Label27.Hide()
            Form2.Label28.Hide()
            Form2.Label29.Hide()
            Form2.Label30.Hide()
            TLine5 = 0
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form2.TextBox30.Hide()
        Form2.TextBox37.Hide()
        Form2.Label31.Hide()
        Form2.Label32.Hide()
        Form2.Label33.Hide()
        Form2.Label34.Hide()
        Form2.Label35.Hide()
        Form2.Label36.Hide()
        TLine6 = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form2.TextBox11.Show()
        Form2.TextBox22.Show()
        Form2.Label55.Show()
        Form2.Label56.Show()
        Form2.Label57.Show()
        Form2.Label58.Show()
        Form2.Label59.Show()
        Form2.Label60.Show()
        BLine4 = 1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If BLine5 = 0 Then
            Form2.TextBox11.Hide()
            Form2.TextBox22.Hide()
            Form2.Label55.Hide()
            Form2.Label56.Hide()
            Form2.Label57.Hide()
            Form2.Label58.Hide()
            Form2.Label59.Hide()
            Form2.Label60.Hide()
            BLine4 = 0
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If BLine4 = 1 Then
            Form2.TextBox71.Show()
            Form2.TextBox78.Show()
            Form2.Label61.Show()
            Form2.Label62.Show()
            Form2.Label63.Show()
            Form2.Label64.Show()
            Form2.Label65.Show()
            Form2.Label66.Show()
            BLine5 = 1
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If BLine6 = 0 Then
            Form2.TextBox71.Hide()
            Form2.TextBox78.Hide()
            Form2.Label61.Hide()
            Form2.Label62.Hide()
            Form2.Label63.Hide()
            Form2.Label64.Hide()
            Form2.Label65.Hide()
            Form2.Label66.Hide()
            BLine5 = 0
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If BLine5 = 1 Then
            Form2.TextBox79.Show()
            Form2.TextBox86.Show()
            Form2.Label67.Show()
            Form2.Label68.Show()
            Form2.Label69.Show()
            Form2.Label70.Show()
            Form2.Label71.Show()
            Form2.Label72.Show()
            BLine6 = 1
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form2.TextBox79.Hide()
        Form2.TextBox86.Hide()
        Form2.Label67.Hide()
        Form2.Label68.Hide()
        Form2.Label69.Hide()
        Form2.Label70.Hide()
        Form2.Label71.Hide()
        Form2.Label72.Hide()
        BLine6 = 0
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form2.TextBox2.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Form2.TextBox2.Hide()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form2.TextBox1.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.TextBox1.Hide()
    End Sub

End Class
Public Class InputResizer

    '----------------------------------------------------------
    ' ControlInfo
    ' Structure of original state of all processed controls
    '----------------------------------------------------------
    Private Structure ControlInfo
        Public name As String
        Public parentName As String
        Public leftOffsetPercent As Double
        Public topOffsetPercent As Double
        Public heightPercent As Double
        Public originalHeight As Integer
        Public originalWidth As Integer
        Public widthPercent As Double
        Public originalFontSize As Single
    End Structure

    '-------------------------------------------------------------------------
    ' ctrlDict
    ' Dictionary of (control name, control info) for all processed controls
    '-------------------------------------------------------------------------
    Private ctrlDict As Dictionary(Of String, ControlInfo) = New Dictionary(Of String, ControlInfo)

    '----------------------------------------------------------------------------------------
    ' FindAllControls
    ' Recursive function to process all controls contained in the initially passed
    ' control container and store it in the Control dictionary
    '----------------------------------------------------------------------------------------
    Public Sub FindAllControls(thisCtrl As Control)

        '-- If the current control has a parent, store all original relative position
        '-- and size information in the dictionary.
        '-- Recursively call FindAllControls for each control contained in the
        '-- current Control
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo
                    c.name = ctl.Name
                    c.parentName = ctl.Parent.Name
                    c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight)
                    c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth)
                    c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight)
                    c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth)
                    c.originalFontSize = ctl.Font.Size
                    c.originalHeight = ctl.Height
                    c.originalWidth = ctl.Width
                    ctrlDict.Add(c.name, c)
                End If

            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try

            If ctl.Controls.Count > 0 Then
                FindAllControls(ctl)
            End If

        Next '-- For Each

    End Sub

    '----------------------------------------------------------------------------------------
    ' ResizeAllControls
    ' Recursive function to resize and reposition all controls contained in the Control
    ' dictionary
    '----------------------------------------------------------------------------------------
    Public Sub ResizeAllControls(thisCtrl As Control)

        Dim fontRatioW As Single
        Dim fontRatioH As Single
        Dim fontRatio As Single
        Dim f As Font

        '-- Resize and reposition all controls in the passed control
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo

                    Dim ret As Boolean = False
                    Try
                        '-- Get the current control's info from the control info dictionary
                        ret = ctrlDict.TryGetValue(ctl.Name, c)

                        '-- If found, adjust the current control based on control relative
                        '-- size and position information stored in the dictionary
                        If (ret) Then
                            '-- Size
                            ctl.Width = Int(parentWidth * c.widthPercent)
                            ctl.Height = Int(parentHeight * c.heightPercent)

                            '-- Position
                            ctl.Top = Int(parentHeight * c.topOffsetPercent)
                            ctl.Left = Int(parentWidth * c.leftOffsetPercent)

                            '-- Font
                            f = ctl.Font
                            fontRatioW = ctl.Width / c.originalWidth
                            fontRatioH = ctl.Height / c.originalHeight
                            fontRatio = (fontRatioW +
                            fontRatioH) / 2 '-- average change in control Height and Width
                            ctl.Font = New Font(f.FontFamily,
                            c.originalFontSize * fontRatio, f.Style)

                        End If
                    Catch
                    End Try
                End If
            Catch ex As Exception
            End Try

            '-- Recursive call for controls contained in the current control
            If ctl.Controls.Count > 0 Then
                ResizeAllControls(ctl)
            End If

        Next '-- For Each
    End Sub

End Class