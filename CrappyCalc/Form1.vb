Public Class CrappyCalc
    Dim Box1 As Single
    Dim Box2 As Single
    Dim Result As String
    Dim i As Boolean = True
    Private Sub Berechnen_Click(sender As Object, e As EventArgs) Handles Berechnen.Click
        If CoolBox1.Text = "" Then
            CoolBox1.Text = "0"
            i = False
        End If
        If CoolBox2.Text = "" Then
            CoolBox2.Text = "0"
            i = False
        End If
        If i = True Then
            Box1 = Convert.ToDecimal(CoolBox1.Text)
            Box2 = Convert.ToDecimal(CoolBox2.Text)
            If Plus.Checked Then
                Result = Box1 + Box2
                ErgebnisBox.Text = Result
            End If
            If Minus.Checked Then
                Result = Box1 - Box2
                ErgebnisBox.Text = Result
            End If
            If Mal.Checked Then
                Result = Box1 * Box2
                ErgebnisBox.Text = Result
            End If
            If Geteilt.Checked Then
                Result = Box1 / Box2
                ErgebnisBox.Text = Result
            End If
            CarryButton.Enabled = True
        End If
        i = True

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        CoolBox1.Text = "0"
        CoolBox2.Text = "0"
        ErgebnisBox.Text = ""
    End Sub

    Private Sub CarryButton_Click(sender As Object, e As EventArgs) Handles CarryButton.Click
        CoolBox1.Text = Convert.ToString(Result)
        CoolBox2.Text = "0"
        ErgebnisBox.Text = ""
        CarryButton.Enabled = False
    End Sub

    Private Sub CoolBox1_TextChanged(sender As Object, e As EventArgs) Handles CoolBox1.TextChanged
        If Not IsNumeric(True) Then
            CoolBox1.Text = "0"
        End If

    End Sub

    Private Sub CoolBox2_KeyPress(sender As Object, e As EventArgs) Handles CoolBox2.KeyPress
        If Not IsNumeric(CoolBox2.Text) Then
            CoolBox2.Text = "0"
        End If
    End Sub
End Class
