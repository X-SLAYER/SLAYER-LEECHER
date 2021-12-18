Imports System.Linq
Imports System.IO

Public Class Search_Engine

    Public countProxy As Integer

    Public Sub New()

        InitializeComponent()
        If Not (IO.File.Exists(Application.StartupPath & "\UserAgents.txt")) Then
            NotFound.Text = "UserAgent.txt Not Found"
            My.Settings.RND = False
            RND.Enabled = False
        End If
    End Sub

    Private Sub Search_Engine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CG.Checked = My.Settings.GOOGLE
        CP.Checked = My.Settings.Pastebin
        CB.Checked = My.Settings.Bing
        CY.Checked = My.Settings.YANDEX
        RND.Checked = My.Settings.RND
        ReqMethode.SelectedIndex = My.Settings.REQUESTMETHODE
        Me.text_proxyType.SelectedIndex = My.Settings.PROXYTYPE
        If Me.text_proxyType.SelectedIndex = 3 Then
            Me.loadProxy.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (countProxy = 0) AndAlso (Me.loadProxy.Enabled) Then
            MsgBox("Select a Proxy FIle Or TurnIT Proxyless", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        My.Settings.GOOGLE = CG.Checked
        My.Settings.Bing = CB.Checked
        My.Settings.Pastebin = CP.Checked
        My.Settings.YANDEX = CY.Checked
        My.Settings.RND = RND.Checked
        My.Settings.PROXYTYPE = Me.text_proxyType.SelectedIndex
        My.Settings.PROXYLESS = Me.text_proxyType.SelectedIndex = 3
        My.Settings.REQUESTMETHODE = Me.ReqMethode.SelectedIndex
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub text_proxyType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles text_proxyType.SelectedIndexChanged
        If Me.text_proxyType.SelectedIndex = 3 Then
            Me.loadProxy.Enabled = False
            Form1.Helper.UseProxy = False
        Else
            Me.loadProxy.Enabled = True
            Form1.Helper.UseProxy = True
        End If
    End Sub

    Private Sub loadProxy_Click(sender As Object, e As EventArgs) Handles loadProxy.Click
        Using dialog As OpenFileDialog = New OpenFileDialog
            dialog.Filter = "Text Files|*.txt"
            If (dialog.ShowDialog = DialogResult.OK) Then
                Form1.Helper.proxy = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllLines(dialog.FileName)))
                Me.countProxy = Form1.Helper.proxy.Length
                Me.loadProxy.Text = ("Loaded Proxy: " & Me.countProxy.ToString)
            Else
                Exit Sub
            End If
        End Using
    End Sub

End Class