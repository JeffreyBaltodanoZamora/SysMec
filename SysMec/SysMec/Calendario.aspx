<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="SysMec.Calendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Estilos.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 316px;

        }
        .auto-style2 {
            width: 126px;
        }
        .auto-style3 {
            height: 40px;
        }
        .auto-style4 {
            width: 126px;
            height: 30px;
        }
        .newStyle1 {
            border: medium double #000000;
        }
        .newStyle2 {
            border: medium inset #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 320px">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">LUNES</td>
                <td class="auto-style2">MARTES</td>
                <td class="auto-style2">MIERCOLES</td>
                <td class="auto-style2">JUEVES</td>
                <td class="auto-style2">VIERNES</td>
                <td class="auto-style2">SABADO</td>
                <td class="auto-style2">DOMINGO</td>
            </tr>
            <tr>
                <td class="auto-style2">01<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select></td>
                <td class="auto-style2">02<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>

                </td>
                
                <td class="auto-style2">03<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">04<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">05<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">06<br />
                </td>
                <td class="auto-style2">07<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">08<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">09<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">10<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">11<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">12<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">13<br />
                </td>
                <td class="auto-style2">14<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">15<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">16<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">17<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">18<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">19<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">20<br />
                </td>
                <td class="auto-style2">21<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">22<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">23<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">24<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">25<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">26<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style2">27<br />
                </td>
                <td class="auto-style2">28<br />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    29<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                </td>
                <td class="auto-style4">
                    30<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                    <br />
                </td>
                <td class="auto-style4">
                    31<br />
                    <select name="Horas Disponibles" class="auto-style3">
                                        <option>6:00 am</option>
                                        <option>6:20 am</option>
                                        <option>6:40 am</option>
                                        <option>7:00 am</option>
                                        <option>7:20 am</option>
                                        <option>7:40 am</option>
                                        <option>8:00 am a 8:20 am  DESAYUNO</option>
                                        <option>8:20 am</option>
                                        <option>8:40 am</option>
                                        <option>9:00 am</option>
                                        <option>9:20 am</option>
                                        <option>9:40 am</option>
                                        <option>10:00 am</option>
                                        <option>10:20 am</option>
                                        <option>10:40 am</option>
                                        <option>11:00 am</option>
                                        <option>11:20 am</option>
                                        <option>11:40 am</option>
                                        <option>12:00 pm a 1:00 pm  ALMUERZO</option>
                                        <option>1:00 pm</option>
                                        <option>1:20 pm</option>
                                        <option>1:40 pm</option>
                                        <option>2:00 pm</option>
                                        <option>2:20 pm</option>
                                        <option>2:40 pm</option>
                                        <option>3:00 pm</option>
                                        <option>3:00 a 3:20 pm  CAFÉ</option>
                                        <option>3:20 pm</option>
                                        <option>3:40 pm</option>
                                        <option>4:00 pm</option>
                                        </select>
                    <br />
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style4">
                </td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>





<%--comentarios--%>