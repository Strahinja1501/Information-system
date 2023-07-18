<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Porudzbenica
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New FontAwesome.Sharp.IconButton()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxID.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBoxID.Location = New System.Drawing.Point(315, 12)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxID.TabIndex = 141
        Me.TextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxID.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(254, 378)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 112)
        Me.Button4.TabIndex = 140
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(170, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 112)
        Me.Button3.TabIndex = 131
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(85, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 112)
        Me.Button2.TabIndex = 130
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(5, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 112)
        Me.Button1.TabIndex = 129
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(315, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(609, 478)
        Me.DataGridView1.TabIndex = 128
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(125, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 26)
        Me.TextBox1.TabIndex = 124
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(125, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 26)
        Me.TextBox2.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "ID Artikla"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "ID Mušterije"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(125, 125)
        Me.TextBox5.MaxLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(148, 26)
        Me.TextBox5.TabIndex = 145
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Usluga"
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.IconChar = FontAwesome.Sharp.IconChar.Sistrix
        Me.Button5.IconColor = System.Drawing.Color.Black
        Me.Button5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button5.IconSize = 30
        Me.Button5.Location = New System.Drawing.Point(244, 7)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 26)
        Me.Button5.TabIndex = 147
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(21, 12)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(216, 26)
        Me.TextBox10.TabIndex = 146
        '
        'Porudzbenica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 502)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Porudzbenica"
        Me.Text = "Porudzbenica"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox10 As TextBox
End Class
