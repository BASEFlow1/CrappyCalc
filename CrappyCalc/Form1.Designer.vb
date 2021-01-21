<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrappyCalc
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrappyCalc))
        Me.Berechnen = New System.Windows.Forms.Button()
        Me.CoolBox1 = New System.Windows.Forms.TextBox()
        Me.CoolBox2 = New System.Windows.Forms.TextBox()
        Me.ErgebnisBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Geteilt = New System.Windows.Forms.RadioButton()
        Me.Minus = New System.Windows.Forms.RadioButton()
        Me.Mal = New System.Windows.Forms.RadioButton()
        Me.Plus = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CarryButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Berechnen
        '
        Me.Berechnen.Location = New System.Drawing.Point(231, 31)
        Me.Berechnen.Name = "Berechnen"
        Me.Berechnen.Size = New System.Drawing.Size(75, 23)
        Me.Berechnen.TabIndex = 0
        Me.Berechnen.Text = "Berechnen"
        Me.Berechnen.UseVisualStyleBackColor = True
        '
        'CoolBox1
        '
        Me.CoolBox1.Location = New System.Drawing.Point(26, 80)
        Me.CoolBox1.Name = "CoolBox1"
        Me.CoolBox1.Size = New System.Drawing.Size(120, 20)
        Me.CoolBox1.TabIndex = 1
        '
        'CoolBox2
        '
        Me.CoolBox2.Location = New System.Drawing.Point(393, 80)
        Me.CoolBox2.Name = "CoolBox2"
        Me.CoolBox2.Size = New System.Drawing.Size(100, 20)
        Me.CoolBox2.TabIndex = 2
        '
        'ErgebnisBox
        '
        Me.ErgebnisBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ErgebnisBox.Enabled = False
        Me.ErgebnisBox.Location = New System.Drawing.Point(172, 157)
        Me.ErgebnisBox.Name = "ErgebnisBox"
        Me.ErgebnisBox.Size = New System.Drawing.Size(200, 20)
        Me.ErgebnisBox.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Geteilt)
        Me.GroupBox1.Controls.Add(Me.Minus)
        Me.GroupBox1.Controls.Add(Me.Mal)
        Me.GroupBox1.Controls.Add(Me.Plus)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Geteilt
        '
        Me.Geteilt.AutoSize = True
        Me.Geteilt.Location = New System.Drawing.Point(104, 44)
        Me.Geteilt.Name = "Geteilt"
        Me.Geteilt.Size = New System.Drawing.Size(55, 17)
        Me.Geteilt.TabIndex = 3
        Me.Geteilt.Text = "Geteilt"
        Me.Geteilt.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.AutoSize = True
        Me.Minus.Location = New System.Drawing.Point(104, 20)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(53, 17)
        Me.Minus.TabIndex = 2
        Me.Minus.Text = "Minus"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'Mal
        '
        Me.Mal.AutoSize = True
        Me.Mal.Location = New System.Drawing.Point(7, 44)
        Me.Mal.Name = "Mal"
        Me.Mal.Size = New System.Drawing.Size(42, 17)
        Me.Mal.TabIndex = 1
        Me.Mal.Text = "Mal"
        Me.Mal.UseVisualStyleBackColor = True
        '
        'Plus
        '
        Me.Plus.AutoSize = True
        Me.Plus.Checked = True
        Me.Plus.Location = New System.Drawing.Point(6, 19)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(45, 17)
        Me.Plus.TabIndex = 0
        Me.Plus.TabStop = True
        Me.Plus.Text = "Plus"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(370, 31)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CarryButton
        '
        Me.CarryButton.Enabled = False
        Me.CarryButton.Location = New System.Drawing.Point(98, 31)
        Me.CarryButton.Name = "CarryButton"
        Me.CarryButton.Size = New System.Drawing.Size(75, 23)
        Me.CarryButton.TabIndex = 6
        Me.CarryButton.Text = "Carry"
        Me.CarryButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ist gleich"
        '
        'CrappyCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 203)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CarryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ErgebnisBox)
        Me.Controls.Add(Me.CoolBox2)
        Me.Controls.Add(Me.CoolBox1)
        Me.Controls.Add(Me.Berechnen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrappyCalc"
        Me.Text = "CrappyCalc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Berechnen As Button
    Friend WithEvents CoolBox1 As TextBox
    Friend WithEvents CoolBox2 As TextBox
    Friend WithEvents ErgebnisBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Geteilt As RadioButton
    Friend WithEvents Minus As RadioButton
    Friend WithEvents Mal As RadioButton
    Friend WithEvents Plus As RadioButton
    Friend WithEvents ClearButton As Button
    Friend WithEvents CarryButton As Button
    Friend WithEvents Label1 As Label
End Class
