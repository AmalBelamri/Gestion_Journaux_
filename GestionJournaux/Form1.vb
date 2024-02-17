Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=DESKTOP-D1BV4G8\SQLEXPRESS;
                                 Initial Catalog=TranspAir;Integrated Security=True")
    Private ds As New DataSet()
    Private adp As New SqlDataAdapter()
    Private adpa As New SqlDataAdapter()


    'AFFICHER  
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    adp = New SqlDataAdapter("select * from pilote", con)
    '    adp.Fill(ds, "pilot")
    '    dgv.DataSource = ds.Tables("pilot")
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adp = New SqlDataAdapter("select * from pilote", con)
        adp.Fill(ds, "pilot")
        ComboPilote.DataSource = ds.Tables("pilot")
        ComboPilote.DisplayMember = "nom"
    End Sub

    Private Sub ComboPilote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPilote.SelectedIndexChanged
        adp = New SqlDataAdapter("select * from pilote where pilote=", con)
        adp.Fill(ds, "pilot")
        dgv.DataSource = ds.Tables("pilot")
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RemoveHandler comboPilote.SelectedIndexChanged, AddressOf ComboBox1_SelectedIndexChanged
        GroupBox1.Visible = False
        LabDvg.Top = LabDvg.Top - 250
        dgv.Top = dgv.Top - 250

        Dim req_pilotes As String = "Select * from pilote"
        Dim req_affectations As String = "Select vol,date_vol,pilote,avion,nbpass from affectation"

        adp.SelectCommand = New SqlCommand(req_pilotes, con)

        adp.Fill(ds, "pilote")


        adpa.SelectCommand = New SqlCommand(req_affectations, con)
        adpa.Fill(ds, "affectation")

        Dim req_avion As String = "select nuavion, concat(nuavion, ' [', type , '] ') As nomcompose from avion"
        adp.SelectCommand = New SqlCommand(req_avion, con)
        adp.Fill(ds, "avion")

        Dim req_vol As String = "select novol from vol"
        adp.SelectCommand = New SqlCommand(req_vol, con)
        adp.Fill(ds, "vol")
        'MessageBox.Show(ds.Tables.Count)
        'dgv.DataSource = ds.Tables("affectation")
        'dgv.Columns(0).Width = 200
        'dgv.Columns(1).Width = 200
        'dgv.Columns(2).Visible = False
        'dgv.Columns(3).Width = 150
        'dgv.Columns(4).Width = 150
        'dgv.Width = 700
        'dgv.Refresh()

        'comboPilote.SelectedIndex = -1
        ComboPilote.DisplayMember = "nom"
        ComboPilote.ValueMember = "nopilote"
        ComboPilote.DataSource = ds.Tables("pilote")

        'comboPilote.SelectedItem = ds.Tables(1).Rows(0)(1).ToString()

        'AddHandler comboPilote.SelectedIndexChanged, AddressOf ComboBox1_SelectedIndexChanged
        'comboPilote.Refresh()
        av.DisplayMember = "nomcompose"
        av.ValueMember = "nuavion"
        av.DataSource = ds.Tables("avion")

        voll.DisplayMember = "novol"
        voll.ValueMember = "novol"
        voll.DataSource = ds.Tables("vol")
        ComboPilote.SelectedIndex = 0

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPilote.SelectedIndexChanged

        'MessageBox.Show(String.Concat("pilote=", comboPilote.SelectedValue))
        Try
            'dgv.Rows.Clear()
            liste_Affectation()



            'Dim affs() As DataRow = ds.Tables(1).Select(expression) '.CopyToDataTable()
            'Dim affs() As DataRow = ds.Tables(0).Select("pilote='6723'")
            '.Select(" pilote='6723'").CopyToDataTable()
            'For Each r As DataRow In affs
            'dgv.Rows.Add(r)
            'Next
            'dgv.Refresh()

        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
        End Try
    End Sub

    Private Sub btnAddVol_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LabDvg.Top = LabDvg.Top + 250
        dgv.Top = dgv.Top + 250
        GroupBox1.Visible = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr As DataRow = ds.Tables("affectation").NewRow()
        dr("vol") = voll.SelectedValue
        dr("pilote") = ComboPilote.SelectedValue
        dr("avion") = av.SelectedValue
        'MessageBox.Show(dr("nbpass").GetType().ToString())
        dr("nbpass") = Decimal.Parse(nbPassa.Text)
        dr("date_vol") = datee.Value
        ds.Tables("affectation").Rows.Add(dr)
        liste_Affectation()


    End Sub

    Private Sub liste_Affectation()
        'Dim expression As String = String.Concat("pilote=", comboPilote.SelectedValue.ToString())
        Dim R() As DataRow = ds.Tables("affectation").Select("pilote='" & ComboPilote.SelectedValue & "'")
        'Dim tab As DataTable = ds.Tables("affectation").Select("pilote='" & comboPilote.SelectedValue & "'").CopyToDataTable()
        If R.Count() <> 0 Then
            'If tab.Rows.Count() > 0 Then
            'MessageBox.Show(R(0)(0))
            dgv.DataSource = R.CopyToDataTable()
            'dgv.DataSource = tab

            dgv.Columns(0).Width = 200
            dgv.Columns(1).Width = 200
            dgv.Columns("pilote").Visible = False
            dgv.Columns(3).Width = 150
            dgv.Columns(4).Width = 150
            dgv.Width = 700

        Else
            dgv.DataSource = Nothing

        End If
    End Sub

    'Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    'Dim cb As New SqlCommandBuilder(adp)
    'adp.Update(ds, "affectation")
    ' End Sub



    'Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Try
    '        Dim n As Integer = ds.Tables("affectation").Rows.Count
    '        'MessageBox.Show(ds.Tables("affectation").Rows(n - 1)(4))
    '        adpa.InsertCommand = New SqlCommand("", con)
    '        adpa.InsertCommand.CommandText = "insert into affectation values('" & ds.Tables("affectation").Rows(n - 1)(0) _
    '            & "', '" & ds.Tables("affectation").Rows(n - 1)(1) & "', '" & ds.Tables("affectation").Rows(n - 1)(2) _
    '            & "', '" & ds.Tables("affectation").Rows(n - 1)(3) & "', " _
    '            & ds.Tables("affectation").Rows(n - 1)(4) & ")"
    '        adpa.Update(ds, "affectation")


    '        'Dim cb As New SqlCommandBuilder(adpa)
    '        ''cb.GetInsertCommand()

    '        'adpa.Update(ds, ds.Tables(1).TableName)
    '    Catch ex As Exception
    '        MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            'Dim n As Integer = ds.Tables("affectation").Rows.Count
            ''MessageBox.Show(ds.Tables("affectation").Rows(n - 1)(4))
            'adp.InsertCommand = New SqlCommand("", con)
            'adp.InsertCommand.CommandText = "insert into affectation values('" & ds.Tables("affectation").Rows(n - 1)(0) _
            '    & "', '" & ds.Tables("affectation").Rows(n - 1)(1) & "', '" & ds.Tables("affectation").Rows(n - 1)(2) _
            '    & "', '" & ds.Tables("affectation").Rows(n - 1)(3) & "', " _
            '    & ds.Tables("affectation").Rows(n - 1)(4) & ")"
            'adp.Update(ds, "affectation")
            Dim cb As New SqlCommandBuilder(adpa)
            'cb.GetInsertCommand()

            adpa.Update(ds, "affectation")
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class
