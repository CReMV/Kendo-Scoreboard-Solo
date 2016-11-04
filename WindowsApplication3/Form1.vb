Public Class Form1
    Dim rs As New InputResizer
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
    End Sub

    Private Sub ButtonClear(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Show()

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