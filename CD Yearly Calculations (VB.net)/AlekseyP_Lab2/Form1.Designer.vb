<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.btnCalcYear1 = New System.Windows.Forms.Button()
        Me.btnCalcYear2 = New System.Windows.Forms.Button()
        Me.btnCalcYear3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstOutYearly = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbCurrencies = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Deposit ($)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interest Rate (%)"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(466, 129)
        Me.txtDeposit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(148, 26)
        Me.txtDeposit.TabIndex = 2
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(466, 202)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(148, 26)
        Me.txtRate.TabIndex = 3
        '
        'btnCalcYear1
        '
        Me.btnCalcYear1.BackColor = System.Drawing.Color.LightBlue
        Me.btnCalcYear1.Location = New System.Drawing.Point(42, 441)
        Me.btnCalcYear1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcYear1.Name = "btnCalcYear1"
        Me.btnCalcYear1.Size = New System.Drawing.Size(188, 46)
        Me.btnCalcYear1.TabIndex = 4
        Me.btnCalcYear1.Text = "&Calculate Year 1-3"
        Me.btnCalcYear1.UseVisualStyleBackColor = False
        '
        'btnCalcYear2
        '
        Me.btnCalcYear2.BackColor = System.Drawing.Color.LightBlue
        Me.btnCalcYear2.Enabled = False
        Me.btnCalcYear2.Location = New System.Drawing.Point(288, 441)
        Me.btnCalcYear2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcYear2.Name = "btnCalcYear2"
        Me.btnCalcYear2.Size = New System.Drawing.Size(188, 46)
        Me.btnCalcYear2.TabIndex = 5
        Me.btnCalcYear2.Text = "Calculat&e Year 4-6"
        Me.btnCalcYear2.UseVisualStyleBackColor = False
        '
        'btnCalcYear3
        '
        Me.btnCalcYear3.BackColor = System.Drawing.Color.LightBlue
        Me.btnCalcYear3.Enabled = False
        Me.btnCalcYear3.Location = New System.Drawing.Point(554, 441)
        Me.btnCalcYear3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcYear3.Name = "btnCalcYear3"
        Me.btnCalcYear3.Size = New System.Drawing.Size(182, 46)
        Me.btnCalcYear3.TabIndex = 6
        Me.btnCalcYear3.Text = "Calculate &Year 7-10"
        Me.btnCalcYear3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 395)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Year 1-3 Balance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(298, 395)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Year 4-6 Balance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(556, 395)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Year 7-10 Balance"
        '
        'lstOutYearly
        '
        Me.lstOutYearly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutYearly.FormattingEnabled = True
        Me.lstOutYearly.ItemHeight = 22
        Me.lstOutYearly.Location = New System.Drawing.Point(42, 516)
        Me.lstOutYearly.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstOutYearly.Name = "lstOutYearly"
        Me.lstOutYearly.Size = New System.Drawing.Size(901, 136)
        Me.lstOutYearly.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(242, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(493, 39)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CD Yearly Interest Calculations"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(827, 291)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 52)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(827, 408)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(116, 52)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'cbCurrencies
        '
        Me.cbCurrencies.FormattingEnabled = True
        Me.cbCurrencies.Items.AddRange(New Object() {"US ($)", "Euro (€)", "Shekel (₪)", "Yen(¥)", "AUD (A$)", "Pesos (M$)", "Rubles (₽)", "Pounds (£)", "Rupees (₹)"})
        Me.cbCurrencies.Location = New System.Drawing.Point(466, 274)
        Me.cbCurrencies.Name = "cbCurrencies"
        Me.cbCurrencies.Size = New System.Drawing.Size(148, 28)
        Me.cbCurrencies.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(302, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Currencies"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.AlekseyP_Lab2.My.Resources.Resources.CD_Calculator_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 699)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbCurrencies)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstOutYearly)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalcYear3)
        Me.Controls.Add(Me.btnCalcYear2)
        Me.Controls.Add(Me.btnCalcYear1)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "CD Yearly Interest Calculations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents btnCalcYear1 As Button
    Friend WithEvents btnCalcYear2 As Button
    Friend WithEvents btnCalcYear3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstOutYearly As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbCurrencies As ComboBox
    Friend WithEvents Label7 As Label
End Class
