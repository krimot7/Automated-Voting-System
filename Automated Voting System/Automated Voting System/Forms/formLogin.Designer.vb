<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.lastnameTB = New System.Windows.Forms.TextBox()
        Me.idnumberTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.exitLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.loginBtn)
        Me.GroupBox1.Controls.Add(Me.lastnameTB)
        Me.GroupBox1.Controls.Add(Me.idnumberTB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(266, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOG-IN DETAILS:"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Gold
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.ForeColor = System.Drawing.Color.Black
        Me.loginBtn.Location = New System.Drawing.Point(356, 138)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(144, 46)
        Me.loginBtn.TabIndex = 3
        Me.loginBtn.Text = "LOG-IN"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'lastnameTB
        '
        Me.lastnameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lastnameTB.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lastnameTB.Location = New System.Drawing.Point(153, 99)
        Me.lastnameTB.MaxLength = 50
        Me.lastnameTB.Name = "lastnameTB"
        Me.lastnameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.lastnameTB.Size = New System.Drawing.Size(347, 36)
        Me.lastnameTB.TabIndex = 2
        Me.lastnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'idnumberTB
        '
        Me.idnumberTB.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.idnumberTB.Location = New System.Drawing.Point(153, 42)
        Me.idnumberTB.MaxLength = 25
        Me.idnumberTB.Name = "idnumberTB"
        Me.idnumberTB.Size = New System.Drawing.Size(347, 36)
        Me.idnumberTB.TabIndex = 1
        Me.idnumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(32, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 35)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "LAST NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID NUMBER:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(24, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 73)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "AUTOMATED VOTING SYSTEM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.exitLbl)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(869, 380)
        Me.Panel2.TabIndex = 6
        '
        'exitLbl
        '
        Me.exitLbl.AutoSize = True
        Me.exitLbl.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.exitLbl.Location = New System.Drawing.Point(285, 342)
        Me.exitLbl.Name = "exitLbl"
        Me.exitLbl.Size = New System.Drawing.Size(0, 35)
        Me.exitLbl.TabIndex = 4
        Me.exitLbl.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 23)
        Me.Label3.TabIndex = 6
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(894, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHINMA-University of Iloilo Automated Voting System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents idnumberTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lastnameTB As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exitLbl As System.Windows.Forms.Label

End Class
