<%@page import="java.text.DecimalFormat"%>
<%@page import="java.util.ArrayList"%>
<%@page import="context.AccountDAO"%>
<%@page import="model.SchoolSupplies"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Dụng cụ học tập</title>
        <link rel="icon" href="../images/logo.ico" type="image/icon">
        <link rel="stylesheet" type="text/css" href="../css/style.css">
        <!--<link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap.css">-->
        <link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap-grid.css">
        <link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap-grid.min.css">
        <%
            Object account = session.getAttribute("accountAdmin");
            if (account == null) {
                response.sendRedirect("login.jsp");
            }
            AccountDAO accountDAO = new AccountDAO();
            ArrayList<SchoolSupplies> list = accountDAO.getListAllSchoolSupplies();
            DecimalFormat formatter = new DecimalFormat("###,###,###");
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container">
                <h2>Quản lý dụng cụ học tập</h2>
                <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-3">
                        <a href="addSchoolSupplies.jsp" class="btn btn-success btn-block">Thêm dụng cụ học tập</a>
                    </div>
                </div>
                <br><br>
                <div class="row">
                    <div class="col-md-1"></div>
                    <div class="col-md-10">
                        <table border="2">
                            <tr style="text-align: center">
                                <th style="width: 50px;">Mã</th>
                                <th>Mã loại</th>
                                <th>Tên dụng cụ học tập</th>
                                <th>Ảnh</th>
                                <th>Giá</th>
                                <th style="width: 100px;">Mô tả</th>
                                <th style="width: 50px;"></th>
                                <th style="width: 50px;"></th>
                            </tr>
                        <%for (SchoolSupplies schoolsupplies : list) {%>
                        <tr style="text-align: center">
                            <td><%=schoolsupplies.getSchoolSuppliesID()%></td>
                            <td><%=schoolsupplies.getCategoryID()%></td>
                            <td><%=schoolsupplies.getSchoolSuppliesName()%></td>
                            <td><img src="../<%=schoolsupplies.getSchoolSuppliesImage()%>" alt="" height="100"></td>
                            <td><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</td>
                            <td><a href="schoolsuppliesDescription.jsp?id=<%=schoolsupplies.getSchoolSuppliesID()%>" >Xem chi tiết</a></td>
                            <td><a href="editSchoolSupplies.jsp?id=<%=schoolsupplies.getSchoolSuppliesID()%>">Edit</a></td>
                            <td><a href="/SchoolSuppliesWeb/AdminDeleteSchoolSupplies?id=<%=schoolsupplies.getSchoolSuppliesID()%>">Delete</a></td>
                        </tr>
                        <%}%>
                    </table>
                    <br>
                    <br><br>
                </div>
            </div>
        </div>
    </body>
</html>
