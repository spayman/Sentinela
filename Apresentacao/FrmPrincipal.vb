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
    'Botão para fechar a aplicação
    Private Sub icoFechar_Click(sender As Object, e As EventArgs) Handles icoFechar.Click
        Application.Exit()
    End Sub
    'Botão para maximizar a aplicação
    Private Sub icoMaximizar_Click(sender As Object, e As EventArgs) Handles icoMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        icoRestaurar.Visible = True
        icoMaximizar.Visible = False
    End Sub
    'Botão para minimizar a aplicação
    Private Sub icoMinimizar_Click(sender As Object, e As EventArgs) Handles icoMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Botão para restaurar a aplicação
    Private Sub icoRestaurar_Click(sender As Object, e As EventArgs) Handles icoRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        icoRestaurar.Visible = False
        icoMaximizar.Visible = True
    End Sub
    'Evento mouseDown responsalvel por chamar as funções que movimenta o form pela barra de titulo
    Private Sub pnlTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'Sub que carrega o form na tela principal
    Private Sub abrirFormNoPainel(ByVal FormFilho As Object)
        If Me.pnlConteudo.Controls.Count > 0 Then
            Me.pnlConteudo.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(FormFilho, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.pnlConteudo.Controls.Add(fh)
        Me.pnlConteudo.Tag = fh
        fh.Show()
    End Sub
    Private Sub bntProdutos_Click(sender As Object, e As EventArgs) Handles bntProdutos.Click
        abrirFormNoPainel(New FrmProdutos)
    End Sub

    Private Sub btnVendas_Click(sender As Object, e As EventArgs) Handles btnVendas.Click
        abrirFormNoPainel(New FrmVendas)
    End Sub
End Class
