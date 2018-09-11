<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Apresentacao
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
        Me.pnlVertical = New System.Windows.Forms.Panel()
        Me.btnFuncionarios = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnFornecedores = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVendas = New System.Windows.Forms.Button()
        Me.bntProdutos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.icoMaximizar = New System.Windows.Forms.PictureBox()
        Me.icoMinimizar = New System.Windows.Forms.PictureBox()
        Me.icoRestaurar = New System.Windows.Forms.PictureBox()
        Me.icoFechar = New System.Windows.Forms.PictureBox()
        Me.pnlConteudo = New System.Windows.Forms.Panel()
        Me.pnlVertical.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.icoMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlVertical
        '
        Me.pnlVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlVertical.Controls.Add(Me.btnFuncionarios)
        Me.pnlVertical.Controls.Add(Me.btnCompras)
        Me.pnlVertical.Controls.Add(Me.btnFornecedores)
        Me.pnlVertical.Controls.Add(Me.btnClientes)
        Me.pnlVertical.Controls.Add(Me.btnVendas)
        Me.pnlVertical.Controls.Add(Me.bntProdutos)
        Me.pnlVertical.Controls.Add(Me.PictureBox1)
        Me.pnlVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlVertical.Location = New System.Drawing.Point(0, 0)
        Me.pnlVertical.Name = "pnlVertical"
        Me.pnlVertical.Size = New System.Drawing.Size(250, 650)
        Me.pnlVertical.TabIndex = 0
        '
        'btnFuncionarios
        '
        Me.btnFuncionarios.FlatAppearance.BorderSize = 0
        Me.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionarios.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionarios.ForeColor = System.Drawing.Color.White
        Me.btnFuncionarios.Image = Global.Sentinela_v1._0.My.Resources.Resources.empleados
        Me.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncionarios.Location = New System.Drawing.Point(0, 365)
        Me.btnFuncionarios.Name = "btnFuncionarios"
        Me.btnFuncionarios.Size = New System.Drawing.Size(250, 40)
        Me.btnFuncionarios.TabIndex = 7
        Me.btnFuncionarios.Text = "Funcionários"
        Me.btnFuncionarios.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.Color.White
        Me.btnCompras.Image = Global.Sentinela_v1._0.My.Resources.Resources.pagos
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(0, 309)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(250, 40)
        Me.btnCompras.TabIndex = 6
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnFornecedores
        '
        Me.btnFornecedores.FlatAppearance.BorderSize = 0
        Me.btnFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFornecedores.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFornecedores.ForeColor = System.Drawing.Color.White
        Me.btnFornecedores.Image = Global.Sentinela_v1._0.My.Resources.Resources.compras
        Me.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFornecedores.Location = New System.Drawing.Point(0, 253)
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.Size = New System.Drawing.Size(250, 40)
        Me.btnFornecedores.TabIndex = 5
        Me.btnFornecedores.Text = "Fornecedores"
        Me.btnFornecedores.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = Global.Sentinela_v1._0.My.Resources.Resources.clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 197)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(250, 40)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnVendas
        '
        Me.btnVendas.FlatAppearance.BorderSize = 0
        Me.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendas.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendas.ForeColor = System.Drawing.Color.White
        Me.btnVendas.Image = Global.Sentinela_v1._0.My.Resources.Resources.venta
        Me.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVendas.Location = New System.Drawing.Point(0, 141)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Size = New System.Drawing.Size(250, 40)
        Me.btnVendas.TabIndex = 3
        Me.btnVendas.Text = "Vendas"
        Me.btnVendas.UseVisualStyleBackColor = True
        '
        'bntProdutos
        '
        Me.bntProdutos.FlatAppearance.BorderSize = 0
        Me.bntProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.bntProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntProdutos.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntProdutos.ForeColor = System.Drawing.Color.White
        Me.bntProdutos.Image = Global.Sentinela_v1._0.My.Resources.Resources.producto1
        Me.bntProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntProdutos.Location = New System.Drawing.Point(0, 85)
        Me.bntProdutos.Name = "bntProdutos"
        Me.bntProdutos.Size = New System.Drawing.Size(250, 40)
        Me.bntProdutos.TabIndex = 2
        Me.bntProdutos.Text = "Produtos"
        Me.bntProdutos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sentinela_v1._0.My.Resources.Resources.IMO2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTitulo.Controls.Add(Me.icoMaximizar)
        Me.pnlTitulo.Controls.Add(Me.icoMinimizar)
        Me.pnlTitulo.Controls.Add(Me.icoRestaurar)
        Me.pnlTitulo.Controls.Add(Me.icoFechar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(250, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1050, 50)
        Me.pnlTitulo.TabIndex = 1
        '
        'icoMaximizar
        '
        Me.icoMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.icoMaximizar.Image = Global.Sentinela_v1._0.My.Resources.Resources.icon_maximizar
        Me.icoMaximizar.Location = New System.Drawing.Point(992, 12)
        Me.icoMaximizar.Name = "icoMaximizar"
        Me.icoMaximizar.Size = New System.Drawing.Size(19, 20)
        Me.icoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoMaximizar.TabIndex = 1
        Me.icoMaximizar.TabStop = False
        '
        'icoMinimizar
        '
        Me.icoMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.icoMinimizar.Image = Global.Sentinela_v1._0.My.Resources.Resources.icon_minimizar
        Me.icoMinimizar.Location = New System.Drawing.Point(966, 12)
        Me.icoMinimizar.Name = "icoMinimizar"
        Me.icoMinimizar.Size = New System.Drawing.Size(19, 20)
        Me.icoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoMinimizar.TabIndex = 3
        Me.icoMinimizar.TabStop = False
        '
        'icoRestaurar
        '
        Me.icoRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.icoRestaurar.Image = Global.Sentinela_v1._0.My.Resources.Resources.icon_restaurar
        Me.icoRestaurar.Location = New System.Drawing.Point(992, 12)
        Me.icoRestaurar.Name = "icoRestaurar"
        Me.icoRestaurar.Size = New System.Drawing.Size(19, 20)
        Me.icoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoRestaurar.TabIndex = 2
        Me.icoRestaurar.TabStop = False
        '
        'icoFechar
        '
        Me.icoFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icoFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.icoFechar.Image = Global.Sentinela_v1._0.My.Resources.Resources.icon_cerrar2
        Me.icoFechar.Location = New System.Drawing.Point(1018, 12)
        Me.icoFechar.Name = "icoFechar"
        Me.icoFechar.Size = New System.Drawing.Size(19, 20)
        Me.icoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoFechar.TabIndex = 0
        Me.icoFechar.TabStop = False
        '
        'pnlConteudo
        '
        Me.pnlConteudo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConteudo.BackColor = System.Drawing.Color.Transparent
        Me.pnlConteudo.Location = New System.Drawing.Point(250, 50)
        Me.pnlConteudo.Name = "pnlConteudo"
        Me.pnlConteudo.Size = New System.Drawing.Size(1050, 600)
        Me.pnlConteudo.TabIndex = 2
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.pnlConteudo)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.pnlVertical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlVertical.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitulo.ResumeLayout(False)
        CType(Me.icoMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlVertical As Panel
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents pnlConteudo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents icoFechar As PictureBox
    Friend WithEvents icoMaximizar As PictureBox
    Friend WithEvents icoRestaurar As PictureBox
    Friend WithEvents icoMinimizar As PictureBox
    Friend WithEvents bntProdutos As Button
    Friend WithEvents btnFuncionarios As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnFornecedores As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnVendas As Button
End Class
