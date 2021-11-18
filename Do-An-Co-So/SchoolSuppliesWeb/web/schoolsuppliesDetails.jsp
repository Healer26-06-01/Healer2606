<%@page import="model.Category"%>
<%@page import="java.text.DecimalFormat"%>
<%@page import="context.AccountDAO"%>
<%@page import="model.SchoolSupplies"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>SchoolSupplies Details</title>
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
        <link rel="stylesheet" type="text/css" href="css/style.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css">

        <%
            String id = request.getParameter("schoolsuppliesID");
            SchoolSupplies schoolsupplies = new AccountDAO().getSchoolSuppliesById(id);
            DecimalFormat formatter = new DecimalFormat("###,###,###");
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container" style="padding-top: 50px;">
                <h2>Chi tiết sản phẩm</h2>
                <div class="row">
                    <div class="col-md-6">		
                        <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" height="600">
                        </div>			
                    </a>			
                </div>
                <div class="col-md-6">
                    <div style="font-size: 40px;">
                        <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class="row" style="padding-top: 100px;">
                <div class="col-md-4">
                    <p>Mã dụng cụ học tập</p>
                    <p>Thể loại</p>
                    <p>Tên dụng cụ học tập</p>
                    <p>Giá</p>
                    <p>Mô tả</p>
                </div>
                <div class="col-md-8">
                    <p><%=schoolsupplies.getSchoolSuppliesID()%></p>
                    <p><%if (schoolsupplies.getCategoryID() == 1) {%>
                        Sổ tay
                        <%} %>
                    </p>
                    <p>
                        <%if (schoolsupplies.getCategoryID() == 2) {%>
                        Vở viết
                        <%} %>
                    </p>
                    <p>
                        <%if (schoolsupplies.getCategoryID() == 3) {%>
                        Bút
                        <%} %></p>
                    <p>
                        <%if (schoolsupplies.getCategoryID() == 4) {%>
                        Sticker
                        <%} %></p>
                    <p>
                        <%if (schoolsupplies.getCategoryID() == 5) {%>
                        Đất sét tự khô
                        <%}%>
                    </p>
                    <p><%=schoolsupplies.getSchoolSuppliesName()%></p>
                    <p><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</p>
                    <p><%=schoolsupplies.getSchoolSuppliesDescription()%></p>
                </div>
            </div>
        </div>
        <jsp:include page="footer.jsp"></jsp:include>
    </body>
</html>
