Imports System.Text

Public Class CalculateLibrary

    'code from a common library
    Sub New()
        IsActive = True
        ModifiedDate = DateTime.Now
        CreatedBy = Environment.UserName
    End Sub

    Dim value1, value2, result As Double
    Dim index1 As Integer = 0
    Dim index2 As Integer = 0

    Public Property IsActive As Boolean
        Public Property ModifiedDate As DateTime
        Public Property CreatedBy As String

        Public Overrides Function ToString() As String
            Return GetClassData()
        End Function

    Protected Overridable Function GetClassData() As String
        Dim sb As New StringBuilder(1024)

        sb.AppendLine("Is Active: " + IsActive.ToString())
        sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
        sb.AppendLine("Created By: " + CreatedBy)

        Return sb.ToString()
    End Function

End Class

'code from a calculator app

'Public Class Form1
'    Dim value1, value2, result As Double
'    Dim index1 As Integer = 0
'    Dim index2 As Integer = 0

'    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        txtDisplay.Enabled = False
'        txtDisplay.Text = 0
'        txtDisplay.TextAlign = HorizontalAlignment.Right

'    End Sub

'    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click

'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn7.Text
'        Else
'            txtDisplay.Text &= btn7.Text
'        End If
'    End Sub

'    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn8.Text
'        Else
'            txtDisplay.Text &= btn8.Text
'        End If
'    End Sub

'    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn9.Text
'        Else
'            txtDisplay.Text &= btn9.Text
'        End If
'    End Sub

'    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn4.Text
'        Else
'            txtDisplay.Text &= btn4.Text
'        End If
'    End Sub

'    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn5.Text
'        Else
'            txtDisplay.Text &= btn5.Text
'        End If
'    End Sub

'    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn6.Text
'        Else
'            txtDisplay.Text &= btn6.Text
'        End If
'    End Sub

'    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn1.Text
'        Else
'            txtDisplay.Text &= btn1.Text
'        End If
'    End Sub

'    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn2.Text
'        Else
'            txtDisplay.Text &= btn2.Text
'        End If
'    End Sub

'    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
'        If txtDisplay.Text = 0 Then
'            txtDisplay.Text = btn3.Text
'        Else
'            txtDisplay.Text &= btn3.Text
'        End If
'    End Sub

'    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
'        txtDisplay.Text = txtDisplay.Text & btn0.Text
'    End Sub

'    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot.Click
'        txtDisplay.Text = txtDisplay.Text & btnDot.Text
'    End Sub

'    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
'        txtDisplay.Text = 0
'    End Sub

'    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
'        value1 = txtDisplay.Text
'        txtDisplay.Text = 0
'        index1 = 1
'    End Sub

'    Private Sub btnMinize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinize.Click
'        value1 = txtDisplay.Text
'        txtDisplay.Text = 0
'        index1 = 2
'    End Sub

'    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
'        value1 = txtDisplay.Text
'        txtDisplay.Text = 0
'        index1 = 3
'    End Sub

'    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
'        value2 = txtDisplay.Text
'        If index1 = 1 Then
'            result = value1 + value2
'            txtDisplay.Text = result
'            index1 = 0
'        ElseIf index1 = 2 Then
'            result = value1 - value2
'            txtDisplay.Text = result
'            index1 = 0
'        ElseIf index1 = 3 Then
'            result = value1 * value2
'            txtDisplay.Text = result
'            index1 = 0
'        End If
'    End Sub
'End Class

