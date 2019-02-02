Option Explicit On
Public Class Form1
    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String
    Dim hasDecimal As Boolean
    Dim tmpValue As Double

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button9.Click, Button8.Click, Button7.Click, Button5.Click, Button4.Click, Button15.Click, Button13.Click, Button12.Click, Button11.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        Dim loc As Integer
        If TextBox1.Text.Length > 0 Then
            str = TextBox1.Text.Chars(TextBox1.Text.Length - 1)
            If str = "." Then
            End If
            loc = TextBox1.Text.Length
            TextBox1.Text = TextBox1.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "0"
        TextBox2.Text = ""
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Operand1 = Val(TextBox1.Text)
        TextBox2.Text = TextBox2.Text & TextBox1.Text & "/"
        TextBox1.Text = ""
        TextBox1.Focus()
        [Operator] = "/"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        [Operator] = "^"
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Operand1 = Val(TextBox1.Text)
        TextBox2.Text = TextBox2.Text & TextBox1.Text & "*"
        TextBox1.Text = ""
        TextBox1.Focus()
        [Operator] = "*"
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Operand1 = Val(TextBox1.Text)
        TextBox2.Text = TextBox2.Text & TextBox1.Text & "-"
        TextBox1.Text = ""
        TextBox1.Focus()
        [Operator] = "-"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Operand1 = Val(TextBox1.Text)
        TextBox2.Text = TextBox2.Text & TextBox1.Text & "+"
        TextBox1.Text = ""
        TextBox1.Focus()
        [Operator] = "+"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If TextBox1.Text.Length <> 0 Then
            tmpValue = CType(TextBox1.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            TextBox1.Text = CType(tmpValue, String)
            hasDecimal = False
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim convert As Single
        If TextBox1.Text <> 0 Then
            convert = 1 / Val(TextBox1.Text)
            TextBox1.Text = convert
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If TextBox1.Text.Length <> 0 Then
            TextBox1.Text = -1 * TextBox1.Text
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If InStr(TextBox1.Text, ".") > 0 Then
            Exit Sub
        End If
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim result As Double
        Operand2 = Val(TextBox1.Text)
        Select Case [Operator]
            Case "+"
                result = Operand1 + Operand2
                TextBox1.Text = result.ToString()
            Case "-"
                result = Operand1 - Operand2
                TextBox1.Text = result.ToString()
            Case "/"
                result = Operand1 / Operand2
                TextBox1.Text = result.ToString()
            Case "*"
                result = Operand1 * Operand2
                TextBox1.Text = result.ToString()
            Case "^"
                result = Operand1 ^ Operand2
                TextBox1.Text = result.ToString()
            Case "%"
                result = Operand1 * 1 / 100
                TextBox1.Text = result.ToString()
        End Select
        TextBox1.Text = result.ToString()
        TextBox2.Text = ""
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If (TextBox1.Visible = True ^ TextBox2.Visible = True) Then
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox2.Text = ""
        Else
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If (TextBox1.Visible = False ^ TextBox2.Visible = False) Then
            Button23.Location = New Point(8, -9)
            Button23.Text = "!"
        ElseIf (TextBox2.Text.Length = 0) Then
            Button23.Location = New Point(60, 30)
            Button23.Text = "Please ON your Calculator"
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
