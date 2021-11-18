<%@page import="model.SchoolSupplies"%>
<%@page import="context.AccountDAO"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Mô tả dụng cụ học tập</title>
        <link rel="icon" href="../images/logo.ico" type="image/icon">
        <link rel="stylesheet" type="text/css" href="../css/style.css">
        <!--<link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap.css">-->
        <link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap-grid.css">
        <link rel="stylesheet" type="text/css" href="../bootstrap/css/bootstrap-grid.min.css">
        <%
            Object account = session.getAttribute("accountAdmin");
            if(account == null){
                response.sendRedirect("login.jsp");
            }
            String id = request.getParameter("id");
            AccountDAO accountDAO = new AccountDAO();
            SchoolSupplies schoolsupplies = accountDAO.getSchoolSuppliesById(id);
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container">
                <h2>Mô tả dụng cụ học tập</h2>
                <h4>Tên dụng cụ học tập: <%=schoolsupplies.getSchoolSuppliesName()%></h4>
                <div class="row">
                    <div class="col-md-12">
                        <table width="95%">
                            <tr><textarea style="width: 500px; height: 200px;"><%=schoolsupplies.getSchoolSuppliesDescription()%></textarea></tr>
                    </table>
                </div>
                <br><br>
                <a href="schoolsupplies.jsp">Quay lại trang quản lí dụng cụ học tập</a>
            </div>
        </div>
    </body>
</html>
