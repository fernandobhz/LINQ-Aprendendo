<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.maior_limite_credito = New System.Windows.Forms.Button()
        Me.clientes_por_cep = New System.Windows.Forms.Button()
        Me.cliente_sem_telefone = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimiteCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BairroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'maior_limite_credito
        '
        Me.maior_limite_credito.Location = New System.Drawing.Point(23, 247)
        Me.maior_limite_credito.Name = "maior_limite_credito"
        Me.maior_limite_credito.Size = New System.Drawing.Size(304, 23)
        Me.maior_limite_credito.TabIndex = 0
        Me.maior_limite_credito.Text = "Cliente com maior limite de credito"
        Me.maior_limite_credito.UseVisualStyleBackColor = True
        '
        'clientes_por_cep
        '
        Me.clientes_por_cep.Location = New System.Drawing.Point(23, 276)
        Me.clientes_por_cep.Name = "clientes_por_cep"
        Me.clientes_por_cep.Size = New System.Drawing.Size(304, 23)
        Me.clientes_por_cep.TabIndex = 1
        Me.clientes_por_cep.Text = "Clientes por CEP"
        Me.clientes_por_cep.UseVisualStyleBackColor = True
        '
        'cliente_sem_telefone
        '
        Me.cliente_sem_telefone.Location = New System.Drawing.Point(23, 305)
        Me.cliente_sem_telefone.Name = "cliente_sem_telefone"
        Me.cliente_sem_telefone.Size = New System.Drawing.Size(304, 23)
        Me.cliente_sem_telefone.TabIndex = 2
        Me.cliente_sem_telefone.Text = "Clientes sem telefone"
        Me.cliente_sem_telefone.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeDataGridViewTextBoxColumn, Me.LimiteCreditoDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.EnderecoDataGridViewTextBoxColumn, Me.BairroDataGridViewTextBoxColumn, Me.CidadeDataGridViewTextBoxColumn, Me.UFDataGridViewTextBoxColumn, Me.CEPDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClienteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(453, 196)
        Me.DataGridView1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.Label1.Location = New System.Drawing.Point(360, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(517, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(474, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(492, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "novo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataRepeater1
        '
        Me.DataRepeater1.DataSource = Me.BindingSource1
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.TextBox1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label2)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(550, 100)
        Me.DataRepeater1.Location = New System.Drawing.Point(675, 42)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(558, 539)
        Me.DataRepeater1.TabIndex = 8
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.TextBox1.Location = New System.Drawing.Point(114, 17)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.Label2.Location = New System.Drawing.Point(33, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Nome", True))
        Me.TextBox2.Location = New System.Drawing.Point(517, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(WindowsApplication1.Cliente)
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(WindowsApplication1.Cliente)
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'LimiteCreditoDataGridViewTextBoxColumn
        '
        Me.LimiteCreditoDataGridViewTextBoxColumn.DataPropertyName = "LimiteCredito"
        Me.LimiteCreditoDataGridViewTextBoxColumn.HeaderText = "LimiteCredito"
        Me.LimiteCreditoDataGridViewTextBoxColumn.Name = "LimiteCreditoDataGridViewTextBoxColumn"
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        '
        'EnderecoDataGridViewTextBoxColumn
        '
        Me.EnderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.HeaderText = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.Name = "EnderecoDataGridViewTextBoxColumn"
        '
        'BairroDataGridViewTextBoxColumn
        '
        Me.BairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.HeaderText = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.Name = "BairroDataGridViewTextBoxColumn"
        '
        'CidadeDataGridViewTextBoxColumn
        '
        Me.CidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.HeaderText = "Cidade"
        Me.CidadeDataGridViewTextBoxColumn.Name = "CidadeDataGridViewTextBoxColumn"
        '
        'UFDataGridViewTextBoxColumn
        '
        Me.UFDataGridViewTextBoxColumn.DataPropertyName = "UF"
        Me.UFDataGridViewTextBoxColumn.HeaderText = "UF"
        Me.UFDataGridViewTextBoxColumn.Name = "UFDataGridViewTextBoxColumn"
        '
        'CEPDataGridViewTextBoxColumn
        '
        Me.CEPDataGridViewTextBoxColumn.DataPropertyName = "CEP"
        Me.CEPDataGridViewTextBoxColumn.HeaderText = "CEP"
        Me.CEPDataGridViewTextBoxColumn.Name = "CEPDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(455, 351)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 619)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cliente_sem_telefone)
        Me.Controls.Add(Me.clientes_por_cep)
        Me.Controls.Add(Me.maior_limite_credito)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents maior_limite_credito As System.Windows.Forms.Button
    Friend WithEvents clientes_por_cep As System.Windows.Forms.Button
    Friend WithEvents cliente_sem_telefone As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LimiteCreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BairroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
