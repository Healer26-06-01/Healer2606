<%@page import="model.Category"%>
<%@page import="java.util.ArrayList"%>
<%@page import="model.SchoolSupplies"%>
<%@page import="context.AccountDAO"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Chỉnh sửa dụng cụ học tập</title>
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
            ArrayList<Category> list = accountDAO.getListCategory();
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container">
                <h2>Chỉnh sửa dụng cụ học tập</h2>
                <br><br>
                <div class="row">
                    <div class="col-md-3">
                        <p>Mã dụng cụ học tập:</p>
                        <p>Loại dụng cụ học tập:</p>
                        <p>Tên dụng cụ học tập:</p>
                        <p>Ảnh:</p>
                        <p>Tải ảnh lên:</p>
                        <p>Giá:</p>
                        <p>Mô Tả:</p>
                    </div>
                    <div class="col-md-9">
                        <form action="/SchoolSuppliesWeb/AdminEditSchoolSupplies" method="POST">
                            <p><input readonly="" type="text" name="schoolsuppliesId" value="<%=schoolsupplies.getSchoolSuppliesID()%>"></p>
                        <p>
                            <select name="categoryId">
                                <%for (Category category : list) {%>
                                <option value="<%=category.getCategoryID()%>"><%=category.getCategoryName()%></option>
                                <%}%>
                            </select>
                        </p>
                        <p><input type="text" name="schoolsuppliesName" value="<%=schoolsupplies.getSchoolSuppliesName()%>"></p>
                        <p><input type="file" value="<%=schoolsupplies.getSchoolSuppliesImage()%>" class="sedang" name="schoolsuppliesImage"></p>
                        <p><input type="number" name="schoolsuppliesPrice" value="<%=schoolsupplies.getSchoolSuppliesPrice()%>"> VNĐ</p> 
                        <p><textarea name="schoolsuppliesDescription" style="width: 300px; height: 100px;"><%=schoolsupplies.getSchoolSuppliesDescription()%></textarea></p>
                        <p><input type="submit" value="Xác nhận"></p>
                    </form>                 
                </div>
            </div>
        </div>
    </body>
</html>
