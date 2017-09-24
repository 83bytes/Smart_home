<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomA
	Inherits MaterialSkin.Controls.MaterialForm


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
		Me.control = New MaterialSkin.Controls.MaterialTabControl()
		Me.Lighttab = New System.Windows.Forms.TabPage()
		Me.temptab = New System.Windows.Forms.TabPage()
		Me.apptab = New System.Windows.Forms.TabPage()
		Me.vidtab = New System.Windows.Forms.TabPage()
		Me.Stattab = New System.Windows.Forms.TabPage()
		Me.Tabselect = New MaterialSkin.Controls.MaterialTabSelector()
		Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
		Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.control.SuspendLayout()
		Me.Lighttab.SuspendLayout()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'control
		'
		Me.control.Controls.Add(Me.Lighttab)
		Me.control.Controls.Add(Me.temptab)
		Me.control.Controls.Add(Me.apptab)
		Me.control.Controls.Add(Me.vidtab)
		Me.control.Controls.Add(Me.Stattab)
		Me.control.Depth = 0
		Me.control.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.control.Location = New System.Drawing.Point(0, 97)
		Me.control.MouseState = MaterialSkin.MouseState.HOVER
		Me.control.Name = "control"
		Me.control.SelectedIndex = 0
		Me.control.Size = New System.Drawing.Size(754, 462)
		Me.control.TabIndex = 0
		'
		'Lighttab
		'
		Me.Lighttab.BackColor = System.Drawing.Color.White
		Me.Lighttab.Controls.Add(Me.MaterialRadioButton2)
		Me.Lighttab.Controls.Add(Me.MaterialRadioButton1)
		Me.Lighttab.Location = New System.Drawing.Point(4, 22)
		Me.Lighttab.Name = "Lighttab"
		Me.Lighttab.Padding = New System.Windows.Forms.Padding(3)
		Me.Lighttab.Size = New System.Drawing.Size(746, 436)
		Me.Lighttab.TabIndex = 0
		Me.Lighttab.Text = "Lights"
		'
		'temptab
		'
		Me.temptab.BackColor = System.Drawing.Color.White
		Me.temptab.Location = New System.Drawing.Point(4, 22)
		Me.temptab.Name = "temptab"
		Me.temptab.Padding = New System.Windows.Forms.Padding(3)
		Me.temptab.Size = New System.Drawing.Size(746, 436)
		Me.temptab.TabIndex = 1
		Me.temptab.Text = "Temperature"
		'
		'apptab
		'
		Me.apptab.BackColor = System.Drawing.Color.White
		Me.apptab.Location = New System.Drawing.Point(4, 22)
		Me.apptab.Name = "apptab"
		Me.apptab.Size = New System.Drawing.Size(746, 436)
		Me.apptab.TabIndex = 2
		Me.apptab.Text = "Appliances"
		Me.apptab.UseVisualStyleBackColor = True
		'
		'vidtab
		'
		Me.vidtab.BackColor = System.Drawing.Color.White
		Me.vidtab.Location = New System.Drawing.Point(4, 22)
		Me.vidtab.Name = "vidtab"
		Me.vidtab.Size = New System.Drawing.Size(746, 436)
		Me.vidtab.TabIndex = 3
		Me.vidtab.Text = "Video"
		Me.vidtab.UseVisualStyleBackColor = True
		'
		'Stattab
		'
		Me.Stattab.BackColor = System.Drawing.Color.White
		Me.Stattab.Location = New System.Drawing.Point(4, 22)
		Me.Stattab.Name = "Stattab"
		Me.Stattab.Size = New System.Drawing.Size(746, 436)
		Me.Stattab.TabIndex = 4
		Me.Stattab.Text = "Statistics"
		Me.Stattab.UseVisualStyleBackColor = True
		'
		'Tabselect
		'
		Me.Tabselect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Tabselect.BaseTabControl = Me.control
		Me.Tabselect.Depth = 0
		Me.Tabselect.Location = New System.Drawing.Point(0, 63)
		Me.Tabselect.MouseState = MaterialSkin.MouseState.HOVER
		Me.Tabselect.Name = "Tabselect"
		Me.Tabselect.Size = New System.Drawing.Size(754, 28)
		Me.Tabselect.TabIndex = 1
		Me.Tabselect.Text = "Tabselect"
		'
		'MaterialRadioButton1
		'
		Me.MaterialRadioButton1.Depth = 0
		Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.MaterialRadioButton1.Location = New System.Drawing.Point(21, 39)
		Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
		Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
		Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
		Me.MaterialRadioButton1.Ripple = True
		Me.MaterialRadioButton1.Size = New System.Drawing.Size(55, 30)
		Me.MaterialRadioButton1.TabIndex = 0
		Me.MaterialRadioButton1.TabStop = True
		Me.MaterialRadioButton1.Text = "ON"
		Me.MaterialRadioButton1.UseVisualStyleBackColor = True
		'
		'MaterialRadioButton2
		'
		Me.MaterialRadioButton2.Checked = True
		Me.MaterialRadioButton2.Depth = 0
		Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
		Me.MaterialRadioButton2.Location = New System.Drawing.Point(22, 94)
		Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
		Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
		Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
		Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
		Me.MaterialRadioButton2.Ripple = True
		Me.MaterialRadioButton2.Size = New System.Drawing.Size(55, 30)
		Me.MaterialRadioButton2.TabIndex = 1
		Me.MaterialRadioButton2.TabStop = True
		Me.MaterialRadioButton2.Text = "OFF"
		Me.MaterialRadioButton2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Transparent
		Me.Button1.BackgroundImage = Global.homematic.My.Resources.Resources.icons8_Chevron_Left_26
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.Button1.Location = New System.Drawing.Point(4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(15, 15)
		Me.Button1.TabIndex = 7
		Me.Button1.UseVisualStyleBackColor = False
		'
		'PictureBox5
		'
		Me.PictureBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox5.Image = Global.homematic.My.Resources.Resources.icons8_Statistics_50
		Me.PictureBox5.Location = New System.Drawing.Point(480, 33)
		Me.PictureBox5.Name = "PictureBox5"
		Me.PictureBox5.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox5.TabIndex = 6
		Me.PictureBox5.TabStop = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox4.Image = Global.homematic.My.Resources.Resources.icons8_Video_Call_50__1_
		Me.PictureBox4.Location = New System.Drawing.Point(380, 33)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox4.TabIndex = 5
		Me.PictureBox4.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox3.Image = Global.homematic.My.Resources.Resources.icons8_Electrical_50
		Me.PictureBox3.Location = New System.Drawing.Point(276, 33)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox3.TabIndex = 4
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox2.Image = Global.homematic.My.Resources.Resources.icons8_Temperature_50__1_
		Me.PictureBox2.Location = New System.Drawing.Point(154, 33)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 3
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Image = Global.homematic.My.Resources.Resources.icons8_Light_Automation_50__1_
		Me.PictureBox1.Location = New System.Drawing.Point(42, 33)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(35, 30)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'RoomA
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(754, 559)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.PictureBox5)
		Me.Controls.Add(Me.PictureBox4)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Tabselect)
		Me.Controls.Add(Me.control)
		Me.Name = "RoomA"
		Me.control.ResumeLayout(False)
		Me.Lighttab.ResumeLayout(False)
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents control As MaterialSkin.Controls.MaterialTabControl
	Friend WithEvents Lighttab As TabPage
	Friend WithEvents temptab As TabPage
	Friend WithEvents apptab As TabPage
	Friend WithEvents vidtab As TabPage
	Friend WithEvents Stattab As TabPage
	Friend WithEvents Tabselect As MaterialSkin.Controls.MaterialTabSelector
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox5 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
	Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
End Class
