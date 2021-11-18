<%@page import="context.AccountDAO"%>
<%@page import="model.Account"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Chỉnh sửa tài khoản</title>
        <link rel="stylesheet" type="text/css" href="css/style.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap-grid.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap-grid.min.css">
        <%
            Account account = null;
            AccountDAO accountDAO = new AccountDAO();
            account = (Account) session.getAttribute("account");
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container">
                <h2>Chỉnh sửa tài khoản</h2>
                <div class="row" style="padding-top: 100px;">
                    <div class="col-md-4">
                        <p>Tên tài khoản</p>
                        <p>Email</p>
                        <p>Mật khẩu</p>
                        <p>Số điện thoại</p>
                    </div>
                    <div class="col-md-8">
                        <form action="EditAccount" method="POST">
                            <p><input type="text" name="name" value="<%=account.getAccountName()%>" /></p>
                        <p><input type="text" name="email" value="<%=account.getAccountEmail()%>" /></p>
                        <p><input type="text" name="password" value="<%=account.getAccountPass()%>" /></p>
                        <p><input type="text" name="phone" value="<%=account.getAccountPhone()%>" /> </p>
                        <input type="submit" class="btn btn-success" value="Lưu" />
                    </form>
                </div>
            </div>
            <br><br>
        </div>
        <div class="map">
            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d1748.3462683280034!2d106.70862490771101!3d10.34951617570627!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2s!4v1630798090366!5m2!1sen!2s" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
        </div>
        <jsp:include page="footer.jsp"></jsp:include>
    </body>
</html>
