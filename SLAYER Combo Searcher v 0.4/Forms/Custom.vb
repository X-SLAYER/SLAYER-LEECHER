Imports System.Net
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Custom


    Sub New()
        InitializeComponent()

    End Sub

    Public Function IsValidDate(ByVal dateString As String) As Boolean
        Try
            DateTime.ParseExact(dateString, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            Return True
        Catch ex As FormatException
            Return False
        End Try
    End Function

    Public Sub SLAYE_IT(ByRef LINK As String)
        Dim FROM As String() = Frm.Text.Split("/")
        Dim a As String() = Too.Text.Split("/")
        LINK = String.Format("https://www.google.fr/search?q=site:pastebin.com+@yahoo.fr&num=100&tbs=cdr%3A1%2Ccd_min%3A{0}%2F{1}%2F{2}%2Ccd_max%3A{3}%2F{4}%2F{5}&tbm=",
                             FROM(0), FROM(1), FROM(2), a(0), a(1), a(2))

    End Sub

    Private Sub OKE_Click(sender As Object, e As EventArgs) Handles OKE.Click
        If Frm.Text = Nothing And Too.Text = Nothing Then
            Form1.CMResultat.SelectedIndex = 0
            Me.Close()
            Exit Sub
        End If
        If (IsValidDate(Frm.Text) And IsValidDate(Too.Text)) = False Then
            MsgBox("invalid date range" & vbCrLf & "date must be : mm/dd/yyyy", MsgBoxStyle.Exclamation, "X-SLAYER")
        Else
            SLAYE_IT(Form1.L_GET)
            Form1.ISCUSTOM = True
            Me.Close()
        End If
    End Sub

    Private Sub Custom_Load(sender As Object, e As EventArgs) Handles Me.Load
        Frm.Text = DT1.Text
        Too.Text = DT2.Text
    End Sub

    Private Sub DT1_ValueChanged(sender As Object, e As EventArgs) Handles DT1.ValueChanged
        On Error Resume Next
        Frm.Text = DT1.Text
    End Sub

    Private Sub DT2_ValueChanged(sender As Object, e As EventArgs) Handles DT2.ValueChanged
        On Error Resume Next
        Too.Text = DT2.Text
    End Sub
End Class


Module APIs
    Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Public Sub SetCueText(ByRef textbox As List(Of TextBox), ByVal CueText As List(Of String))
        For i As Integer = 0 To textbox.Count - 1
            SendMessage(textbox(i).Handle, EM_SETCUEBANNER, 1, CueText(i))
        Next
    End Sub
End Module