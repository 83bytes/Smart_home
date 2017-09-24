
Imports MaterialSkin

Public Class RoomA

	Private Sub RoomA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
		SkinManager.AddFormToManage(Me)
		SkinManager.Theme = MaterialSkinManager.Themes.DARK
		SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple900, Primary.DeepPurple500, Accent.Yellow200, TextShade.WHITE)
	End Sub

	Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles Lighttab.Click

	End Sub

	Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

	End Sub
End Class

