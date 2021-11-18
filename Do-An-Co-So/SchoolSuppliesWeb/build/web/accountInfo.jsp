<%@page import="context.AccountDAO"%>
<%@page import="model.Account"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Thông tin tài khoản</title>
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>
        <%
            Account account = (Account) session.getAttribute("account");
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"/>
            <div class="container">
                <h2>Thông tin tài khỏan</h2>
                <div class="row" style="padding-top: 100px;">
                    <div class="col-md-4">
                        <p>Mã tài khoản</p>
                        <p>Tên tài khoản</p>
                        <p>Email</p>
                        <p>Mật khẩu</p>
                        <p>Số điện thoại</p>
                    </div>
                    <div class="col-md-8">
                        <p><%=account.getAccountID()%></p>
                    <p><%=account.getAccountName()%></p>
                    <p><%=account.getAccountEmail()%></p>
                    <p><%=account.getAccountPass()%></p>
                    <p><%=account.getAccountPhone()%></p>
                </div>
            </div>
            <div>
                <a href="editAccount.jsp" class="btn btn-success">Chỉnh sửa tài khoản</a>
            </div>
            <br><br>
        </div>
        <jsp:include page="footer.jsp"/>
    </body>
</html>
