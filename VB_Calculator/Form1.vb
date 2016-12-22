Public Class Form1

    ' initializing all variables
    Dim firstNumber As Decimal
    Dim secondNumber As Decimal
    Dim thirdNumber As Decimal
    Dim operatorType As String
    Dim isEqual As String

    ' subroutine for clearing the answer on number or decimal button click
    Sub clearAnswer()
        If isEqual = "=" Then
            displayBox.Clear()
            isEqual = ""
        End If
    End Sub

    ' start of code for buttons, toolbar and form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearAnswer()
        displayBox.Text += "1"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles decimalBtn.Click
        clearAnswer()
        displayBox.Text += "."
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created by Mitchell Console 2016")
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        displayBox.Clear()
        firstNumber = 0
        secondNumber = 0
        thirdNumber = 0
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles displayBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearAnswer()
        displayBox.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearAnswer()
        displayBox.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clearAnswer()
        displayBox.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        clearAnswer()
        displayBox.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clearAnswer()
        displayBox.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        clearAnswer()
        displayBox.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        clearAnswer()
        displayBox.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        clearAnswer()
        displayBox.Text += "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        clearAnswer()
        displayBox.Text += "0"
    End Sub

    Private Sub equalsBtn_Click(sender As Object, e As EventArgs) Handles equalsBtn.Click
        secondNumber = Decimal.Parse(displayBox.Text)
        If operatorType = "+" Then
            thirdNumber = firstNumber + secondNumber
        ElseIf operatorType = "-" Then
            thirdNumber = firstNumber - secondNumber
        ElseIf operatorType = "*" Then
            thirdNumber = firstNumber * secondNumber
        ElseIf operatorType = "\" Then
            thirdNumber = firstNumber \ secondNumber
        End If

        If firstNumber = 0 Then
            displayBox.Text = secondNumber
        Else
            displayBox.Text = thirdNumber
        End If

        isEqual = "="

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        firstNumber = Decimal.Parse(displayBox.Text)
        operatorType = "+"
        displayBox.Clear()
    End Sub

    Private Sub minusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        firstNumber = Decimal.Parse(displayBox.Text)
        operatorType = "-"
        displayBox.Clear()
    End Sub

    Private Sub multiplyBtn_Click(sender As Object, e As EventArgs) Handles multiplyBtn.Click
        firstNumber = Decimal.Parse(displayBox.Text)
        operatorType = "*"
        displayBox.Clear()
    End Sub

    Private Sub divideBtn_Click(sender As Object, e As EventArgs) Handles divideBtn.Click
        firstNumber = Decimal.Parse(displayBox.Text)
        operatorType = "\"
        displayBox.Clear()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        displayBox.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim displayText = displayBox.Text
        Dim newDisplayText As String = ""

        For index As Integer = 0 To displayText.Length - 2
            newDisplayText += displayText(index)
        Next

        displayBox.Text = newDisplayText
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
