Imports System.Runtime.InteropServices
Public Class Apresentacao

    'Função para clicar e movimentar o form pela barra de titulo
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    'Função para clicar e movimentar o form pela barra de titulo
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal _
        wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub txbUsuario_Enter(sender As Object, e As EventArgs) Handles txbUsuario.Enter
        If txbUsuario.Text = "USUÁRIO" Then
            txbUsuario.Text = ""
            txbUsuario.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub txbUsuario_Leave(sender As Object, e As EventArgs) Handles txbUsuario.Leave
        If txbUsuario.Text = "" Then
            txbUsuario.Text = "USUÁRIO"
            txbUsuario.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub txbSenha_Enter(sender As Object, e As EventArgs) Handles txbSenha.Enter
        If txbSenha.Text = "SENHA" Then
            txbSenha.Text = ""
            txbSenha.ForeColor = Color.LightGray
            txbSenha.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub txbSenha_Leave(sender As Object, e As EventArgs) Handles txbSenha.Leave
        If txbSenha.Text = "" Then
            txbSenha.Text = "SENHA"
            txbSenha.ForeColor = Color.DimGray
            txbSenha.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class