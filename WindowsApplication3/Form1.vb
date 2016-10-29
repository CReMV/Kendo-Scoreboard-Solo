Public Class Form1
    Dim rs As New InputResizer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Form2.TextBox1.Text = TextBox1.Text
        Form2.TextBox2.Text = TextBox2.Text
        Form2.TextBox3.Text = TextBox33.Text
        Form2.TextBox45.Text = TextBox3.Text
        Form2.TextBox52.Text = TextBox4.Text
        Form2.TextBox8.Text = TextBox34.Text
        Form2.TextBox5.Text = TextBox35.Text
        Form2.TextBox10.Text = TextBox36.Text
        Form2.TextBox6.Text = TextBox37.Text
        Form2.TextBox38.Text = TextBox38.Text
        Form2.TextBox39.Text = TextBox39.Text
        Form2.TextBox40.Text = TextBox40.Text
        Form2.TextBox41.Text = TextBox41.Text
        Form2.TextBox42.Text = TextBox42.Text
        Form2.TextBox44.Text = TextBox44.Text
        Form2.TextBox13.Text = ComboBox1.Text
        Form2.TextBox19.Text = ComboBox2.Text
        Form2.TextBox18.Text = ComboBox3.Text
        Form2.TextBox9.Text = ComboBox4.Text
        Form2.TextBox14.Text = ComboBox5.Text
        Form2.TextBox4.Text = ComboBox6.Text
        Form2.TextBox15.Text = ComboBox7.Text
        Form2.TextBox20.Text = ComboBox8.Text
        Form2.TextBox21.Text = ComboBox9.Text
        Form2.TextBox16.Text = ComboBox10.Text
        Form2.TextBox22.Text = ComboBox11.Text
        Form2.TextBox17.Text = ComboBox12.Text
        Form2.TextBox11.Text = ComboBox13.Text
        Form2.TextBox12.Text = ComboBox14.Text
        Form2.TextBox7.Text = ComboBox15.Text
        Form2.TextBox23.Text = ComboBox16.Text
        Form2.TextBox33.Text = ComboBox17.Text
        Form2.TextBox28.Text = ComboBox18.Text
        Form2.TextBox24.Text = ComboBox19.Text
        Form2.TextBox29.Text = ComboBox20.Text
        Form2.TextBox34.Text = ComboBox21.Text
        Form2.TextBox25.Text = ComboBox22.Text
        Form2.TextBox30.Text = ComboBox23.Text
        Form2.TextBox35.Text = ComboBox24.Text
        Form2.TextBox26.Text = ComboBox25.Text
        Form2.TextBox31.Text = ComboBox26.Text
        Form2.TextBox36.Text = ComboBox27.Text
        Form2.TextBox27.Text = ComboBox28.Text
        Form2.TextBox32.Text = ComboBox29.Text
        Form2.TextBox37.Text = ComboBox30.Text
        Form2.TextBox46.Text = ComboBox31.Text
        Form2.TextBox47.Text = ComboBox32.Text
        Form2.TextBox48.Text = ComboBox33.Text
        Form2.TextBox49.Text = ComboBox34.Text
        Form2.TextBox50.Text = ComboBox35.Text
        Form2.TextBox51.Text = ComboBox36.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Show()
        Me.TextBox1.Text = "Team 1"
        Me.TextBox2.Text = "Team 2"
        Me.TextBox3.Text = "Player"
        Me.TextBox4.Text = "Player"
        Me.TextBox38.Text = "Player 1"
        Me.TextBox39.Text = "Player 2"
        Me.TextBox40.Text = "Player 3"
        Me.TextBox41.Text = "Player 4"
        Me.TextBox42.Text = "Player 5"
        Me.TextBox44.Text = "Team 1 VS Team 2"
        Me.TextBox33.Text = "Player 1"
        Me.TextBox34.Text = "Player 2"
        Me.TextBox35.Text = "Player 3"
        Me.TextBox36.Text = "PLayer 4"
        Me.TextBox37.Text = "Player 5"
        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox5.Text = ""
        Me.ComboBox6.Text = ""
        Me.ComboBox7.Text = ""
        Me.ComboBox8.Text = ""
        Me.ComboBox9.Text = ""
        Me.ComboBox10.Text = ""
        Me.ComboBox11.Text = ""
        Me.ComboBox12.Text = ""
        Me.ComboBox13.Text = ""
        Me.ComboBox14.Text = ""
        Me.ComboBox15.Text = ""
        Me.ComboBox16.Text = ""
        Me.ComboBox17.Text = ""
        Me.ComboBox18.Text = ""
        Me.ComboBox19.Text = ""
        Me.ComboBox20.Text = ""
        Me.ComboBox21.Text = ""
        Me.ComboBox22.Text = ""
        Me.ComboBox23.Text = ""
        Me.ComboBox24.Text = ""
        Me.ComboBox25.Text = ""
        Me.ComboBox26.Text = ""
        Me.ComboBox27.Text = ""
        Me.ComboBox28.Text = ""
        Me.ComboBox29.Text = ""
        Me.ComboBox30.Text = ""
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