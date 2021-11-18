<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Thanh toán</title>
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="login">
                <div class="container">
                    <h2>Thanh toán</h2>
                    <br>
                    <form action="bill" method="POST"> 
                        <div class="col-md-6 login-do1 animated wow fadeInLeft">
                            <span>Địa chỉ của bạn * : </span>
                            <br>
                            <div class="login-mail">
                                <input type="text" placeholder="Số nhà, đường, phường, quận..." name="address" required>
                            </div>
                            <span>Họ và tên</span>
                            <br>
                            <div class="login-mail">
                                <input type="text" placeholder="Họ và tên của người nhận hàng" name="name" required>
                            </div>
                            <span>Điện thoại</span>
                            <br>
                            <div class="login-mail">
                                <input type="text" placeholder="Điện thoại di động của người nhận hàng" name="phone" required>
                            </div>
                            <div>
                                <span>Phương thức thanh toán * : </span>
                                <select name="payment">
                                    <option value="Bank transfer">Chuyển khoản</option>
                                    <option value="Live">Trực tiếp</option>
                                </select>
                            </div>
                        </div>
                        <div class="col-md-6 login-do animated wow fadeInRight">
                            <label class="btn btn-success btn-block">
                                <input type="submit" value="Thanh toán ngay bây giờ">
                            </label>
                        </div>
                    </form>
                </div>
            </div>   
            <br>
        <jsp:include page="footer.jsp"></jsp:include>
    </body>
</html>
