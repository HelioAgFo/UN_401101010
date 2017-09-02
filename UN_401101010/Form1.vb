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
        Call Init_SOShipHeader(LEVEL1, True)
        Call ScreenInit()

        Spread1 = DetailSetup(CSR_SOShipHeader, DslGrid1, bSOShipHeader.AddressOf("ShipperID"), bSOShipHeader, PNULL, PNULL, PNULL)

        With Timer1
            .Interval = 10000
            .Enabled = True
            .Start()
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
            RetVal = NoAutoChk
        End If

    End Sub
End Class
