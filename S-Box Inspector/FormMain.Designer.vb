<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.DataGridView_LAT = New System.Windows.Forms.DataGridView
        Me.DataGridView_XOR = New System.Windows.Forms.DataGridView
        Me.StatusStrip_Info = New System.Windows.Forms.StatusStrip
        Me.Label_Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.ComboBox_DES = New System.Windows.Forms.ComboBox
        Me.Button_Compute = New System.Windows.Forms.Button
        Me.DataGridView_LC = New System.Windows.Forms.DataGridView
        Me.Label_LATMax = New System.Windows.Forms.Label
        Me.Label_XORMax = New System.Windows.Forms.Label
        Me.RadioButton_DES = New System.Windows.Forms.RadioButton
        Me.RadioButton_Serpent = New System.Windows.Forms.RadioButton
        Me.RadioButton_TwoFish = New System.Windows.Forms.RadioButton
        Me.ComboBox_Serpent = New System.Windows.Forms.ComboBox
        Me.ComboBox_TwoFish = New System.Windows.Forms.ComboBox
        Me.RadioButton_Special = New System.Windows.Forms.RadioButton
        Me.TextBox_SpecialSBox = New System.Windows.Forms.TextBox
        Me.Button_Save = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Button_All = New System.Windows.Forms.Button
        Me.Label_LCFInfo = New System.Windows.Forms.Label
        CType(Me.DataGridView_LAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_XOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip_Info.SuspendLayout()
        CType(Me.DataGridView_LC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_LAT
        '
        Me.DataGridView_LAT.AllowUserToAddRows = False
        Me.DataGridView_LAT.AllowUserToDeleteRows = False
        Me.DataGridView_LAT.AllowUserToResizeColumns = False
        Me.DataGridView_LAT.AllowUserToResizeRows = False
        Me.DataGridView_LAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_LAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView_LAT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView_LAT.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView_LAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LAT.Location = New System.Drawing.Point(12, 199)
        Me.DataGridView_LAT.MultiSelect = False
        Me.DataGridView_LAT.Name = "DataGridView_LAT"
        Me.DataGridView_LAT.ReadOnly = True
        Me.DataGridView_LAT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_LAT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView_LAT.Size = New System.Drawing.Size(410, 346)
        Me.DataGridView_LAT.TabIndex = 13
        '
        'DataGridView_XOR
        '
        Me.DataGridView_XOR.AllowUserToAddRows = False
        Me.DataGridView_XOR.AllowUserToDeleteRows = False
        Me.DataGridView_XOR.AllowUserToResizeColumns = False
        Me.DataGridView_XOR.AllowUserToResizeRows = False
        Me.DataGridView_XOR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_XOR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView_XOR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView_XOR.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView_XOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_XOR.Location = New System.Drawing.Point(428, 199)
        Me.DataGridView_XOR.MultiSelect = False
        Me.DataGridView_XOR.Name = "DataGridView_XOR"
        Me.DataGridView_XOR.ReadOnly = True
        Me.DataGridView_XOR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_XOR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView_XOR.Size = New System.Drawing.Size(410, 346)
        Me.DataGridView_XOR.TabIndex = 15
        '
        'StatusStrip_Info
        '
        Me.StatusStrip_Info.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label_Status})
        Me.StatusStrip_Info.Location = New System.Drawing.Point(0, 569)
        Me.StatusStrip_Info.Name = "StatusStrip_Info"
        Me.StatusStrip_Info.Size = New System.Drawing.Size(850, 22)
        Me.StatusStrip_Info.TabIndex = 3
        Me.StatusStrip_Info.Text = "StatusStrip1"
        '
        'Label_Status
        '
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(219, 17)
        Me.Label_Status.Text = "Ready  --- Halil Kemal TAŞKIN, METU IAM ---"
        '
        'ComboBox_DES
        '
        Me.ComboBox_DES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_DES.FormattingEnabled = True
        Me.ComboBox_DES.Location = New System.Drawing.Point(92, 11)
        Me.ComboBox_DES.Name = "ComboBox_DES"
        Me.ComboBox_DES.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_DES.TabIndex = 1
        '
        'Button_Compute
        '
        Me.Button_Compute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button_Compute.ForeColor = System.Drawing.Color.Red
        Me.Button_Compute.Location = New System.Drawing.Point(494, 9)
        Me.Button_Compute.Name = "Button_Compute"
        Me.Button_Compute.Size = New System.Drawing.Size(344, 23)
        Me.Button_Compute.TabIndex = 8
        Me.Button_Compute.Text = "Compute everything for the selected S-Box"
        Me.Button_Compute.UseVisualStyleBackColor = True
        '
        'DataGridView_LC
        '
        Me.DataGridView_LC.AllowUserToAddRows = False
        Me.DataGridView_LC.AllowUserToDeleteRows = False
        Me.DataGridView_LC.AllowUserToResizeColumns = False
        Me.DataGridView_LC.AllowUserToResizeRows = False
        Me.DataGridView_LC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_LC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView_LC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_LC.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView_LC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_LC.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView_LC.MultiSelect = False
        Me.DataGridView_LC.Name = "DataGridView_LC"
        Me.DataGridView_LC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_LC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView_LC.Size = New System.Drawing.Size(826, 110)
        Me.DataGridView_LC.TabIndex = 11
        '
        'Label_LATMax
        '
        Me.Label_LATMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_LATMax.AutoSize = True
        Me.Label_LATMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label_LATMax.Location = New System.Drawing.Point(12, 548)
        Me.Label_LATMax.Name = "Label_LATMax"
        Me.Label_LATMax.Size = New System.Drawing.Size(367, 16)
        Me.Label_LATMax.TabIndex = 14
        Me.Label_LATMax.Text = "Max. Value: ? (i,j) | Max. Value (Weight 1 Input): ? (i,j)"
        '
        'Label_XORMax
        '
        Me.Label_XORMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_XORMax.AutoSize = True
        Me.Label_XORMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label_XORMax.Location = New System.Drawing.Point(425, 548)
        Me.Label_XORMax.Name = "Label_XORMax"
        Me.Label_XORMax.Size = New System.Drawing.Size(387, 16)
        Me.Label_XORMax.TabIndex = 16
        Me.Label_XORMax.Text = "Max. Value: ? (i,j) | Max. Value with Weight 1 Input: ? (i,j)"
        '
        'RadioButton_DES
        '
        Me.RadioButton_DES.AutoSize = True
        Me.RadioButton_DES.Checked = True
        Me.RadioButton_DES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton_DES.Location = New System.Drawing.Point(12, 12)
        Me.RadioButton_DES.Name = "RadioButton_DES"
        Me.RadioButton_DES.Size = New System.Drawing.Size(57, 20)
        Me.RadioButton_DES.TabIndex = 0
        Me.RadioButton_DES.TabStop = True
        Me.RadioButton_DES.Text = "DES"
        Me.RadioButton_DES.UseVisualStyleBackColor = True
        '
        'RadioButton_Serpent
        '
        Me.RadioButton_Serpent.AutoSize = True
        Me.RadioButton_Serpent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton_Serpent.Location = New System.Drawing.Point(15, 38)
        Me.RadioButton_Serpent.Name = "RadioButton_Serpent"
        Me.RadioButton_Serpent.Size = New System.Drawing.Size(80, 20)
        Me.RadioButton_Serpent.TabIndex = 2
        Me.RadioButton_Serpent.TabStop = True
        Me.RadioButton_Serpent.Text = "Serpent"
        Me.RadioButton_Serpent.UseVisualStyleBackColor = True
        '
        'RadioButton_TwoFish
        '
        Me.RadioButton_TwoFish.AutoSize = True
        Me.RadioButton_TwoFish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton_TwoFish.Location = New System.Drawing.Point(219, 12)
        Me.RadioButton_TwoFish.Name = "RadioButton_TwoFish"
        Me.RadioButton_TwoFish.Size = New System.Drawing.Size(84, 20)
        Me.RadioButton_TwoFish.TabIndex = 4
        Me.RadioButton_TwoFish.TabStop = True
        Me.RadioButton_TwoFish.Text = "TwoFish"
        Me.RadioButton_TwoFish.UseVisualStyleBackColor = True
        '
        'ComboBox_Serpent
        '
        Me.ComboBox_Serpent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Serpent.FormattingEnabled = True
        Me.ComboBox_Serpent.Location = New System.Drawing.Point(92, 37)
        Me.ComboBox_Serpent.Name = "ComboBox_Serpent"
        Me.ComboBox_Serpent.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Serpent.TabIndex = 3
        '
        'ComboBox_TwoFish
        '
        Me.ComboBox_TwoFish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_TwoFish.FormattingEnabled = True
        Me.ComboBox_TwoFish.Location = New System.Drawing.Point(332, 11)
        Me.ComboBox_TwoFish.Name = "ComboBox_TwoFish"
        Me.ComboBox_TwoFish.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox_TwoFish.TabIndex = 5
        '
        'RadioButton_Special
        '
        Me.RadioButton_Special.AutoSize = True
        Me.RadioButton_Special.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton_Special.Location = New System.Drawing.Point(219, 38)
        Me.RadioButton_Special.Name = "RadioButton_Special"
        Me.RadioButton_Special.Size = New System.Drawing.Size(107, 20)
        Me.RadioButton_Special.TabIndex = 6
        Me.RadioButton_Special.TabStop = True
        Me.RadioButton_Special.Text = "Write S-Box"
        Me.RadioButton_Special.UseVisualStyleBackColor = True
        '
        'TextBox_SpecialSBox
        '
        Me.TextBox_SpecialSBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox_SpecialSBox.Location = New System.Drawing.Point(332, 37)
        Me.TextBox_SpecialSBox.Name = "TextBox_SpecialSBox"
        Me.TextBox_SpecialSBox.Size = New System.Drawing.Size(258, 22)
        Me.TextBox_SpecialSBox.TabIndex = 7
        Me.TextBox_SpecialSBox.Text = "0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15"
        '
        'Button_Save
        '
        Me.Button_Save.Enabled = False
        Me.Button_Save.Location = New System.Drawing.Point(596, 37)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(78, 23)
        Me.Button_Save.TabIndex = 9
        Me.Button_Save.Text = "Save to file"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_All
        '
        Me.Button_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_All.Location = New System.Drawing.Point(680, 38)
        Me.Button_All.Name = "Button_All"
        Me.Button_All.Size = New System.Drawing.Size(158, 23)
        Me.Button_All.TabIndex = 10
        Me.Button_All.Text = "Generate table for all"
        Me.Button_All.UseVisualStyleBackColor = True
        '
        'Label_LCFInfo
        '
        Me.Label_LCFInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_LCFInfo.AutoSize = True
        Me.Label_LCFInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label_LCFInfo.Location = New System.Drawing.Point(9, 180)
        Me.Label_LCFInfo.Name = "Label_LCFInfo"
        Me.Label_LCFInfo.Size = New System.Drawing.Size(642, 16)
        Me.Label_LCFInfo.TabIndex = 12
        Me.Label_LCFInfo.Text = "Minimum Degree: ? | Maximum Degree: ? | Minimum Nonlinearity: ? | Maximum Nonline" & _
            "arity: ?"
        '
        'FormMain
        '
        Me.AcceptButton = Me.Button_Compute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 591)
        Me.Controls.Add(Me.Label_LCFInfo)
        Me.Controls.Add(Me.Button_All)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.TextBox_SpecialSBox)
        Me.Controls.Add(Me.RadioButton_Special)
        Me.Controls.Add(Me.ComboBox_TwoFish)
        Me.Controls.Add(Me.ComboBox_Serpent)
        Me.Controls.Add(Me.RadioButton_TwoFish)
        Me.Controls.Add(Me.RadioButton_Serpent)
        Me.Controls.Add(Me.RadioButton_DES)
        Me.Controls.Add(Me.Label_XORMax)
        Me.Controls.Add(Me.Label_LATMax)
        Me.Controls.Add(Me.DataGridView_LC)
        Me.Controls.Add(Me.Button_Compute)
        Me.Controls.Add(Me.ComboBox_DES)
        Me.Controls.Add(Me.StatusStrip_Info)
        Me.Controls.Add(Me.DataGridView_XOR)
        Me.Controls.Add(Me.DataGridView_LAT)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S-Box Inspector - Halil Kemal TAŞKIN © 2010"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView_LAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_XOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip_Info.ResumeLayout(False)
        Me.StatusStrip_Info.PerformLayout()
        CType(Me.DataGridView_LC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_LAT As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView_XOR As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip_Info As System.Windows.Forms.StatusStrip
    Friend WithEvents Label_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ComboBox_DES As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Compute As System.Windows.Forms.Button
    Friend WithEvents DataGridView_LC As System.Windows.Forms.DataGridView
    Friend WithEvents Label_LATMax As System.Windows.Forms.Label
    Friend WithEvents Label_XORMax As System.Windows.Forms.Label
    Friend WithEvents RadioButton_DES As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Serpent As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_TwoFish As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox_Serpent As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_TwoFish As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton_Special As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_SpecialSBox As System.Windows.Forms.TextBox
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button_All As System.Windows.Forms.Button
    Friend WithEvents Label_LCFInfo As System.Windows.Forms.Label

End Class
