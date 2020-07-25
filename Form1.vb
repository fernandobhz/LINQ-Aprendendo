Public Class Form1

    Sub New()
        InitializeComponent()
    End Sub

    Private clientes As New List(Of Cliente)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.clientes.Add(New Cliente With {.Nome = "fernando", .LimiteCredito = 15000, .Endereco = "Av Marte, 748", .Bairro = "Jardim richo das pedras", .Cidade = "Contagem", .UF = "MF", .CEP = "32241250", .Telefone = "(31) 9199-0751"})
        Me.clientes.Add(New Cliente With {.Nome = "sandra", .LimiteCredito = 5000, .Endereco = "Av Marte, 748", .Bairro = "Jardim richo das pedras", .Cidade = "Contagem", .UF = "MF", .CEP = "32240330", .Telefone = "(31) 9921-2308"})
        Me.clientes.Add(New Cliente With {.Nome = "antonio", .LimiteCredito = 1000, .Endereco = "Av Marte, 748", .Bairro = "Jardim richo das pedras", .Cidade = "Contagem", .UF = "MF", .CEP = "32241250", .Telefone = "(31) 3363-0807"})
        Me.clientes.Add(New Cliente With {.Nome = "fulano", .LimiteCredito = 13000, .Endereco = "rua do fulano", .Bairro = "bairropolis", .Cidade = "cidadela", .UF = "UF", .Telefone = "", .CEP = "32240330"})
        Me.clientes.Add(New Cliente With {.Nome = "s l credito", .Endereco = "rua do fulano", .Bairro = "bairropolis", .Cidade = "cidadela", .UF = "UF", .Telefone = ""})

        Me.ClienteBindingSource.DataSource = Me.clientes
        Me.BindingSource1.DataSource = Me.clientes

        Form2.Show()

    End Sub

    Private Sub maior_limite_credito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maior_limite_credito.Click
        Dim q = From c As Cliente In Me.ClienteBindingSource Where c.LimiteCredito > 10000 Order By c.LimiteCredito Descending

        For Each c As Cliente In q
            MsgBox(c.Nome & " " & c.LimiteCredito)
        Next

    End Sub

    Class cg
        Property CEP As String
        Property qtd As Integer
    End Class

    Private Sub clientes_por_cep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clientes_por_cep.Click

        Dim z = From c As Cliente In Me.ClienteBindingSource Group c By c.CEP Into Count() Select CEP, qtd = Count

        For Each o In z
            MsgBox(o.CEP & vbCrLf & o.qtd)
        Next

    End Sub

    Private Sub cliente_sem_telefone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente_sem_telefone.Click
        Dim z = From c As Cliente In Me.ClienteBindingSource Where c.LimiteCredito Is Nothing

        For Each c As Cliente In z
            MsgBox(c.Nome)
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim f = From x In System.IO.Directory.GetFiles("C:\") Order By x




        For Each ss As String In f

            'If ss.CompareTo("C:\B21.FDB") > 0 Then
            '    MsgBox(ss & ss.CompareTo("C:\B21.FDB"))
            'End If


            'If ss.CompareTo(String.Empty) > 0 Then
            '    MsgBox(ss)
            'End If


            MsgBox(ss)


        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        



    End Sub

    Private np As String

    Private Sub Form1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        Me.Controls(Me.np).Location = e.Location
    End Sub

    Private Sub Label1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDoubleClick
        If My.Computer.Keyboard.ShiftKeyDown Then
            MsgBox("Clique onde voce quer o objeto")
            Me.np = "label1"
        Else
            Me.Label1.Text = InputBox("novo nome", "novo nome", Me.Label1.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        MsgBox("a" < "B")
    End Sub
End Class

Class III
    Inherits Form1
    Implements ABC

    Public Sub A() Implements ABC.A

    End Sub
End Class



Interface ABC
    Sub A()
End Interface

'Class crud
'    Private tabela As String

'    Sub New(ByVal tabela As String)
'        Me.tabela = tabela
'    End Sub


'    Sub criacontroles()

'        Dim cols As List(Of coluna) = Me.colunas

'        For Each c As coluna In cols

'            Select Case c.tipo

'                Case "varchar"
'                    Dim x As New TextBox
'                    x.Location = 0;5
'                    x.Text = ""
'                    x.DataBindings = Nothing
'                Case "int"

'                Case "date"

'                Case "time"

'                Case "datetime"

'                Case "decimal"

'                Case "bit"

'                Case "char"

'            End Select

'        Next

'    End Sub

'    Function colunas() As List(Of coluna)

'        Return New List(Of coluna)
'    End Function

'End Class


'Class coluna
'    Property nome As String
'    Property tipo As String
'    Property nulloption As Boolean
'End Class