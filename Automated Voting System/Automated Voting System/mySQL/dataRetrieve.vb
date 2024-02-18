Imports MySql.Data.MySqlClient

Module dataRetrieve

    Public Sub retrievestudentinfo()

        Try
            dbConnection()
            sql = "SELECT * from student_data WHERE ID_No = '" & formLogin.idnumberTB.Text & "';"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                idno = dt.Rows(0).Item(0)
                fullname = dt.Rows(0).Item(1) + ", " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
                lastname = dt.Rows(0).Item(1)
                course = dt.Rows(0).Item(4)
                activation = dt.Rows(0).Item(5)
                voted = dt.Rows(0).Item(6)
                If formLogin.idnumberTB.Text = idno And formLogin.lastnameTB.Text = lastname Then
                    If activation = False Then
                        MsgBox("Activation Required!")
                        clearLogin()
                        formLogin.idnumberTB.Focus()
                    Else
                        If voted = True Then
                            MsgBox("You have already voted!")
                            clearLogin()
                            formLogin.idnumberTB.Focus()
                        Else
                            MsgBox("Welcome " & fullname & "!")
                            retrieveballotno()
                            retrievelocalcandidates()
                            formVotingPane.Show()
                            formLogin.Hide()
                            formVotingPane.studentnameLbl.Text = fullname
                            formVotingPane.courseLbl.Text = course
                            formVotingPane.eballotnoLbl.Text = eballotno
                            clearLogin()
                        End If
                    End If
                Else
                    MsgBox("Incorrect Inputs!")
                    clearLogin()
                    formLogin.idnumberTB.Focus()
                End If
            Else
                MsgBox("Incorrect Inputs!")
                clearLogin()
                formLogin.idnumberTB.Focus()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
            clearLogin()
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub retrieveballotno()

        Try
            dbConnection()
            sql = "SELECT * from eballot_archive WHERE ID_No = @IDNo;"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@IDNo", formLogin.idnumberTB.Text)
            dr = cmd.ExecuteReader
            While dr.Read
                eballotno = dr.GetString("Ballot_No")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try

    End Sub

    Public Sub retrievelocalcandidates()

        'College of Mechanical Engineering
        If course = "ELSP" Then
            COMECandidates()
            department = "COME"
        ElseIf course = "BSMARE" Then
            COMECandidates()
            department = "COME"

            'College of Arts and Sciences
        ElseIf course = "AB" Then
            CASCandidates()
            department = "CAS"
        ElseIf course = "BSPSYCH" Then
            CASCandidates()
            department = "CAS"
        End If

    End Sub

    Public Sub CASCandidates()

        formVotingPane.chairmanCB1.Text = "KRISHNA MOORTHY D"
        formVotingPane.chairmanCB2.Visible = False
        formVotingPane.vicechairmanCB1.Text = "PHILIP THOMAS"
        formVotingPane.vicechairmanCB2.Visible = False
        formVotingPane.lsecretaryCB1.Text = "RAGHURAM P"
        formVotingPane.lsecretaryCB2.Visible = False
        formVotingPane.ltreasurerCB1.Text = "SRIRAM R"
        formVotingPane.ltreasurerCB2.Visible = False
        formVotingPane.lauditorCB1.Visible = False
        formVotingPane.lauditorCB2.Visible = False
        formVotingPane.Label6.Visible = False
        formVotingPane.Label7.Visible = False
        formVotingPane.boardmemberCB1.Visible = False
        formVotingPane.boardmemberCB2.Visible = False
        formVotingPane.boardmemberCB3.Visible = False
        formVotingPane.boardmemberCB4.Visible = False
        formVotingPane.boardmemberCB5.Visible = False

    End Sub

    Public Sub COMECandidates()

        formVotingPane.chairmanCB1.Text = "MANI CHANDRA R"
        formVotingPane.chairmanCB2.Visible = False
        formVotingPane.vicechairmanCB1.Text = "SANDHANAM T"
        formVotingPane.vicechairmanCB2.Visible = False
        formVotingPane.lsecretaryCB1.Text = "VIRAT KOHLI"
        formVotingPane.lsecretaryCB2.Visible = False
        formVotingPane.ltreasurerCB1.Text = "VENKATARAMAN R"
        formVotingPane.ltreasurerCB2.Visible = False
        formVotingPane.lauditorCB1.Text = "BOOPATHI RAVI"
        formVotingPane.lauditorCB2.Visible = False
        formVotingPane.boardmemberCB1.Text = "SENTHIL KUMAR G"
        formVotingPane.boardmemberCB2.Text = "MENAKA V"
        formVotingPane.boardmemberCB3.Text = "RAVEENA THAHA"
        formVotingPane.boardmemberCB4.Visible = False
        formVotingPane.boardmemberCB5.Visible = False

    End Sub

End Module
