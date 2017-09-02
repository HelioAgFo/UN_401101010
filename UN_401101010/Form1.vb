'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
Option Explicit On
Option Strict Off
Friend Class Form1
    Inherits System.Windows.Forms.Form
    Public Spread1 As Short
    Protected m_IsInitializing As Boolean
    Protected ReadOnly Property IsInitializing() As Boolean
        Get
            Return m_IsInitializing
        End Get
    End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        Call ApplInit()

        Call Init_Customer(LEVEL0, True)
        Call Init_xSOShipHeader(LEVEL1, True)
        Call ScreenInit()

        Spread1 = DetailSetup(CSR_xSOShipHeader, DslGrid1, bxSOShipHeader.AddressOf("ShipperID"), bxSOShipHeader, PNULL, PNULL, PNULL)

        Call InitBuffer()

        With Timer1
            .Interval = 10000
            .Enabled = True
            .Start()
        End With



    End Sub

    Private Sub InitBuffer()
        Label5.Text = ""

        With nxSOShipHeader
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            .LUpd_DateTime = bpes.Today
            .LUpd_Prog = bpes.ScrnNbr
            .LUpd_User = bpes.UserId
        End With
    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DslMaskedText1_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cCustid.ChkEvent
        serr = PVChkFetch1(PNULL, CSR_Customer, ChkStrg, bCustomer)
        If serr = NOTFOUND Then
            RetVal = ErrNoMess
            MessBox("Error, No existe el cliente", MB_ICONEXCLAMATION, "Error cliente inexistente")
        Else
            Label5.Text = bCustomer.Name

        End If

    End Sub

    Private Sub Update1_UpdateEvent(Level As Short, InsertFlg As Short, LevelsDone As Short, LevelsLeft As Short, ByRef RetVal As Short) Handles Update1.UpdateEvent
        Dim Query As String
        Dim LoteAgrupador As String
        Dim RecFound As Integer
        Dim MemMaintFlg As Integer
        Dim Agrupar As Integer
        Dim shipperid As String

        LoteAgrupador = ""

        Query = "select S4FUTURE11 from soshipheader group by s4future11"
        Call sql(c1, Query)
        serr1 = SFetch1(c1, LoteAgrupador)

        If LoteAgrupador = "" Then
            LoteAgrupador = "000001"
        Else
            LoteAgrupador = LoteAgrupador + 1
        End If

        'MessBox(LoteAgrupador, MB_ICONEXCLAMATION, "Error cliente inexistente")
        If Level = LEVEL1 Then

            Call Status(StartProcess, False, "", 0)
            RecFound = MFirst(Spread1, MemMaintFlg)
            While (RecFound = 0)
                Agrupar = bxSOShipHeader.S4Future10
                shipperid = bxSOShipHeader.ShipperID
                If Agrupar = 0 Then
                    LoteAgrupador = ""
                End If
                Query = "xspActualiza_Embar_Agrupados" + SParm(shipperid) + SParm(Agrupar) + SParm(LoteAgrupador)
                'Call MessBox(sSql, MB_OK, "Store Procedure")
                Call sql(c1, Query)
                RecFound = MNext(Spread1, MemMaintFlg)

            End While
            Call Status(EndProcess, False, "", 0)
            'Redisplay the grid with the modified contents of the memory array.
            RecFound = MFirst(Spread1, MemMaintFlg)
            Spread1 = DetailSetup(CSR_xSOShipHeader, DslGrid1, bxSOShipHeader.AddressOf("ShipperID"), bxSOShipHeader, PNULL, PNULL, PNULL)
            Call MDisplay(Spread1)
        End If


    End Sub
End Class
