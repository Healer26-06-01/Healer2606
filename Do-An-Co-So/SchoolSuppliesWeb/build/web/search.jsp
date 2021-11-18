<%@page import="java.text.DecimalFormat"%>
<%@page import="model.SchoolSupplies"%>
<%@page import="java.util.ArrayList"%>
<%@page import="context.AccountDAO"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Tìm kiếm dụng cụ học tập</title>
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
        <%
            String schoolsuppliesName = request.getParameter("schoolsuppliesName");
            DecimalFormat formatter = new DecimalFormat("###,###,###");
            AccountDAO accountDAO = new AccountDAO();
            ArrayList<SchoolSupplies> list = accountDAO.getListSearchSchoolSupplies(schoolsuppliesName);
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container">
                <h2>Tìm kiếm dụng cụ học tập</h2>
                <div class="row">
                <%if (list.size() == 0) {%>
                <br>
                <h5 style="margin-left: 500px;">Không có dụng cụ học tập cần tìm</h5>
                <br><br>
                <%}%>  
                <%
                    for (SchoolSupplies schoolsupplies : list) {
                %>
                <div class="col-md-3">		
                    <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" width="280" height="400">
                        </div>			
                    </a>			
                    <div class="women">
                        <h6><a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a></h6>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
                <%}%>
            </div>
        </div>
        <jsp:include page="footer.jsp"></jsp:include>
    </body>
</html>
