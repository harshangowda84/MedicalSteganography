<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InPatientBillingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.butNew = New System.Windows.Forms.Button
        Me.butSave = New System.Windows.Forms.Button
        Me.DG1 = New System.Windows.Forms.DataGridView
        Me.butModify = New System.Windows.Forms.Button
        Me.ButDelete = New System.Windows.Forms.Button
        Me.butList = New System.Windows.Forms.Button
        Me.butClose = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ConDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill No"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 29)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(439, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 23)
        Me.TextBox2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(0, 568)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1023, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'butNew
        '
        Me.butNew.Location = New System.Drawing.Point(16, 579)
        Me.butNew.Name = "butNew"
        Me.butNew.Size = New System.Drawing.Size(106, 30)
        Me.butNew.TabIndex = 6
        Me.butNew.Text = "New"
        Me.butNew.UseVisualStyleBackColor = True
        '
        'butSave
        '
        Me.butSave.Enabled = False
        Me.butSave.Location = New System.Drawing.Point(128, 579)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(106, 30)
        Me.butSave.TabIndex = 7
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = True
        '
        'DG1
        '
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(639, 14)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(365, 548)
        Me.DG1.TabIndex = 8
        '
        'butModify
        '
        Me.butModify.Enabled = False
        Me.butModify.Location = New System.Drawing.Point(240, 579)
        Me.butModify.Name = "butModify"
        Me.butModify.Size = New System.Drawing.Size(106, 30)
        Me.butModify.TabIndex = 9
        Me.butModify.Text = "Modify"
        Me.butModify.UseVisualStyleBackColor = True
        '
        'ButDelete
        '
        Me.ButDelete.Enabled = False
        Me.ButDelete.Location = New System.Drawing.Point(352, 579)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(106, 30)
        Me.ButDelete.TabIndex = 10
        Me.ButDelete.Text = "Delete"
        Me.ButDelete.UseVisualStyleBackColor = True
        '
        'butList
        '
        Me.butList.Location = New System.Drawing.Point(639, 579)
        Me.butList.Name = "butList"
        Me.butList.Size = New System.Drawing.Size(106, 30)
        Me.butList.TabIndex = 11
        Me.butList.Text = "List"
        Me.butList.UseVisualStyleBackColor = True
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(898, 579)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(106, 30)
        Me.butClose.TabIndex = 12
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "In Patient No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Patient Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "1."
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(128, 24)
        Me.ComboBox1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(125, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Particulars"
        '
        'ConDate
        '
        Me.ConDate.CustomFormat = "dd/MMM/yyyy"
        Me.ConDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ConDate.Location = New System.Drawing.Point(439, 29)
        Me.ConDate.Name = "ConDate"
        Me.ConDate.Size = New System.Drawing.Size(128, 23)
        Me.ConDate.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(483, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Amount"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(128, 163)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(290, 23)
        Me.TextBox3.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(486, 163)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(111, 23)
        Me.TextBox4.TabIndex = 34
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(128, 192)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(290, 23)
        Me.TextBox5.TabIndex = 37
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(486, 192)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(111, 23)
        Me.TextBox6.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 195)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "2."
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(128, 223)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(290, 23)
        Me.TextBox7.TabIndex = 40
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(486, 223)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(111, 23)
        Me.TextBox8.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 224)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "3."
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(486, 291)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(111, 23)
        Me.TextBox9.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(360, 298)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Total Amount"
        '
        'InPatientBillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 678)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ConDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butList)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.butModify)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InPatientBillingForm"
        Me.Text = "In Patient Billing Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents butNew As System.Windows.Forms.Button
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents butModify As System.Windows.Forms.Button
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents butList As System.Windows.Forms.Button
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ConDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
