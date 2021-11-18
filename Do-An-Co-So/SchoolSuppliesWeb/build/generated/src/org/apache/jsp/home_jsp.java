package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import java.text.DecimalFormat;
import java.util.ArrayList;
import context.AccountDAO;
import model.SchoolSupplies;

public final class home_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <title>Welcome to Crabit Notebuck</title>\n");
      out.write("        <meta charset=\"utf-8\">\n");
      out.write("        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n");
      out.write("        <link rel=\"icon\" href=\"//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021\" type=\"image/x-icon\" />\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"css/style.css\">\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"bootstrap/css/bootstrap.css\">\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"bootstrap/css/bootstrap.min.css\">\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"bootstrap/css/bootstrap-grid.css\">\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"bootstrap/css/bootstrap-grid.min.css\">\n");
      out.write("        ");

            String id = request.getParameter("id");
            ArrayList<SchoolSupplies> listNewSchoolSupplies = new AccountDAO().getTop6ListNewSchoolSupplies();
            ArrayList<SchoolSupplies> listNoteBookSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(1);
            ArrayList<SchoolSupplies> listPlayWrightSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(2);
             ArrayList<SchoolSupplies> listPenSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(3);
              ArrayList<SchoolSupplies> listStickerSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(4);
               ArrayList<SchoolSupplies> listClaySchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(5);
            DecimalFormat formatter = new DecimalFormat("###,###,###");
        
      out.write("\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("        ");
      org.apache.jasper.runtime.JspRuntimeLibrary.include(request, response, "header.jsp", out, false);
      out.write("\n");
      out.write("            <div class=\"container\" style=\"padding-top: 100px;\">\n");
      out.write("                <h2>Dụng cụ học tập mới</h2>\n");
      out.write("                <div class=\"row\">\n");
      out.write("                ");

                    for (SchoolSupplies schoolsupplies : listNewSchoolSupplies) {
                
      out.write("\n");
      out.write("                <div class=\"col-md-3\">\t\t\n");
      out.write("                    <a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\">\n");
      out.write("                        <div>\n");
      out.write("                            <img src=\"");
      out.print(schoolsupplies.getSchoolSuppliesImage());
      out.write("\"  alt=\"\" width=\"280\" height=\"400\">\n");
      out.write("                        </div>\t\t\t\n");
      out.write("                    </a>\t\t\t\n");
      out.write("                    <div class=\"women\">\n");
      out.write("                        <h6><a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write('"');
      out.write('>');
      out.print(schoolsupplies.getSchoolSuppliesName());
      out.write("</a></h6>\n");
      out.write("                        <p><em class=\"item_price\">");
      out.print(formatter.format(schoolsupplies.getSchoolSuppliesPrice()));
      out.write(" VNĐ</em>\n");
      out.write("                            <br>\n");
      out.write("                            <a href=\"cart?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\" data-text=\"Thêm vào giỏ\">Thêm vào giỏ</a>\n");
      out.write("                        </p>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("                ");
}
      out.write("\n");
      out.write("            </div>\n");
      out.write("            <br><br><br>\n");
      out.write("            <h2>Sổ tay</h2>\n");
      out.write("            <div class=\"row\">\n");
      out.write("                ");

                    for (SchoolSupplies schoolsupplies : listNoteBookSchoolSupplies) {
                
      out.write("\n");
      out.write("                <div class=\"col-md-3\">\t\t\n");
      out.write("                    <a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\">\n");
      out.write("                        <div>\n");
      out.write("                            <img src=\"");
      out.print(schoolsupplies.getSchoolSuppliesImage());
      out.write("\"  alt=\"\" width=\"280\" height=\"400\">\n");
      out.write("                        </div>\t\t\t\n");
      out.write("                    </a>\t\t\t\n");
      out.write("                    <div class=\"women\">\n");
      out.write("                        <h6><a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write('"');
      out.write('>');
      out.print(schoolsupplies.getSchoolSuppliesName());
      out.write("</a></h6>\n");
      out.write("                        <p><em class=\"item_price\">");
      out.print(formatter.format(schoolsupplies.getSchoolSuppliesPrice()));
      out.write(" VNĐ</em>\n");
      out.write("                            <br>\n");
      out.write("                            <a href=\"cart?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\" data-text=\"Thêm vào giỏ\">Thêm vào giỏ</a>\n");
      out.write("                        </p>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("                ");
}
      out.write("\n");
      out.write("            </div>\n");
      out.write("            <br><br><br>\n");
      out.write("            <h2>Vở viết</h2>\n");
      out.write("            <div class=\"row\">\n");
      out.write("                ");

                    for (SchoolSupplies schoolsupplies : listPlayWrightSchoolSupplies) {
                
      out.write("\n");
      out.write("                <div class=\"col-md-3\">\t\t\n");
      out.write("                    <a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\">\n");
      out.write("                        <div>\n");
      out.write("                            <img src=\"");
      out.print(schoolsupplies.getSchoolSuppliesImage());
      out.write("\"  alt=\"\" width=\"280\" height=\"400\">\n");
      out.write("                        </div>\t\t\t\n");
      out.write("                    </a>\t\t\t\n");
      out.write("                    <div class=\"women\">\n");
      out.write("                        <h6><a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write('"');
      out.write('>');
      out.print(schoolsupplies.getSchoolSuppliesName());
      out.write("</a></h6>\n");
      out.write("                        <p><em class=\"item_price\">");
      out.print(formatter.format(schoolsupplies.getSchoolSuppliesPrice()));
      out.write(" VNĐ</em>\n");
      out.write("                            <br>\n");
      out.write("                            <a href=\"cart?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\" data-text=\"Thêm vào giỏ\">Thêm vào giỏ</a>\n");
      out.write("                        </p>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("                ");
}
      out.write("\n");
      out.write("            </div>\n");
      out.write("            <br><br><br>\n");
      out.write("            <h2>Bút</h2>\n");
      out.write("            <div class=\"row\">\n");
      out.write("                ");

                    for (SchoolSupplies schoolsupplies : listPenSchoolSupplies) {
                
      out.write("\n");
      out.write("                <div class=\"col-md-3\">\t\t\n");
      out.write("                    <a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\">\n");
      out.write("                        <div>\n");
      out.write("                            <img src=\"");
      out.print(schoolsupplies.getSchoolSuppliesImage());
      out.write("\"  alt=\"\" width=\"280\" height=\"400\">\n");
      out.write("                        </div>\t\t\t\n");
      out.write("                    </a>\t\t\t\n");
      out.write("                    <div class=\"women\">\n");
      out.write("                        <h6><a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write('"');
      out.write('>');
      out.print(schoolsupplies.getSchoolSuppliesName());
      out.write("</a></h6>\n");
      out.write("                        <p><em class=\"item_price\">");
      out.print(formatter.format(schoolsupplies.getSchoolSuppliesPrice()));
      out.write(" VNĐ</em>\n");
      out.write("                            <br>\n");
      out.write("                            <a href=\"cart?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\" data-text=\"Thêm vào giỏ\">Thêm vào giỏ</a>\n");
      out.write("                        </p>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("                ");
}
      out.write("\n");
      out.write("            </div>\n");
      out.write("            <br><br><br>\n");
      out.write("            <h2>Sticker</h2>\n");
      out.write("            <div class=\"row\">\n");
      out.write("                ");

                    for (SchoolSupplies schoolsupplies : listStickerSchoolSupplies) {
                
      out.write("\n");
      out.write("                <div class=\"col-md-3\">\t\t\n");
      out.write("                    <a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\">\n");
      out.write("                        <div>\n");
      out.write("                            <img src=\"");
      out.print(schoolsupplies.getSchoolSuppliesImage());
      out.write("\"  alt=\"\" width=\"280\" height=\"400\">\n");
      out.write("                        </div>\t\t\t\n");
      out.write("                    </a>\t\t\t\n");
      out.write("                    <div class=\"women\">\n");
      out.write("                        <h6><a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write('"');
      out.write('>');
      out.print(schoolsupplies.getSchoolSuppliesName());
      out.write("</a></h6>\n");
      out.write("                        <p><em class=\"item_price\">");
      out.print(formatter.format(schoolsupplies.getSchoolSuppliesPrice()));
      out.write(" VNĐ</em>\n");
      out.write("                            <br>\n");
      out.write("                            <a href=\"cart?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\" data-text=\"Thêm vào giỏ\">Thêm vào giỏ</a>\n");
      out.write("                        </p>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("                ");
}
      out.write("\n");
      out.write("            </div>\n");
      out.write("            <br><br><br>\n");
      out.write("            <h2>Đất sét tự khô</h2>\n");
      out.write("            <div class=\"row\">\n");
      out.write("                ");

                    for (SchoolSupplies schoolsupplies : listClaySchoolSupplies) {
                
      out.write("\n");
      out.write("                <div class=\"col-md-3\">\t\t\n");
      out.write("                    <a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\">\n");
      out.write("                        <div>\n");
      out.write("                            <img src=\"");
      out.print(schoolsupplies.getSchoolSuppliesImage());
      out.write("\"  alt=\"\" width=\"280\" height=\"400\">\n");
      out.write("                        </div>\t\t\t\n");
      out.write("                    </a>\t\t\t\n");
      out.write("                    <div class=\"women\">\n");
      out.write("                        <h6><a href=\"schoolsuppliesDetails.jsp?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write('"');
      out.write('>');
      out.print(schoolsupplies.getSchoolSuppliesName());
      out.write("</a></h6>\n");
      out.write("                        <p><em class=\"item_price\">");
      out.print(formatter.format(schoolsupplies.getSchoolSuppliesPrice()));
      out.write(" VNĐ</em>\n");
      out.write("                            <br>\n");
      out.write("                            <a href=\"cart?schoolsuppliesID=");
      out.print(schoolsupplies.getSchoolSuppliesID());
      out.write("\" data-text=\"Thêm vào giỏ\">Thêm vào giỏ</a>\n");
      out.write("                        </p>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("                ");
}
      out.write("\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("    </div>\n");
      out.write("    ");
      org.apache.jasper.runtime.JspRuntimeLibrary.include(request, response, "footer.jsp", out, false);
      out.write("\n");
      out.write("    <script src=\"bootstrap/js/jquery.min.js\"></script>\n");
      out.write("    <script src=\"bootstrap/js/bootstrap.min.js\"></script>\n");
      out.write("    <script src=\"js/jquery-3.3.1.min.js\"></script>\n");
      out.write("    <script src=\"js/popper.min.js\"></script>\n");
      out.write("    <script src=\"bootstrap/js/bootstrap.min.js\"></script>\n");
      out.write("</body>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
