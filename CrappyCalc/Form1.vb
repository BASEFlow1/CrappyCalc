Public Class CrappyCalc
    Dim Box1 As Single
    Dim Box2 As Single
    Dim Result As String
    Dim Box1Temp As String
    Dim Box1Numeric As String
    Dim i As Boolean = True
    Sub PlaySystemSoundError()
        My.Computer.Audio.PlaySystemSound(
        System.Media.SystemSounds.Asterisk)
    End Sub
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

    Private Sub CoolBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CoolBox1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 32
            Case Else
                e.Handled = True
                PlaySystemSoundError()
        End Select
    End Sub

    Private Sub CoolBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CoolBox2.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 32
            Case Else
                e.Handled = True
                PlaySystemSoundError()
        End Select
    End Sub
End Class
