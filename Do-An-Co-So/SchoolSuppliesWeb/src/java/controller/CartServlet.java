/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import context.AccountDAO;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import model.Account;
import model.BillDetail;
import model.SchoolSupplies;

/**
 *
 * @author HEALER
 */
public class CartServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        try {
            Account account = null;
            AccountDAO accountDAO = new AccountDAO();
            HttpSession session = request.getSession();
            account = (Account) session.getAttribute("account");
            if(account == null){
                response.sendRedirect("login.jsp");
                return;
            }
            String id = request.getParameter("schoolsuppliesID");
            SchoolSupplies schoolsupplies = accountDAO.getSchoolSuppliesById(id);
            ArrayList<BillDetail> list = new ArrayList<>();
            list = accountDAO.getListBillDetail(account.getAccountID());
            for (int i = 0; i < list.size(); i++) {
                if(id.equals(list.get(i).getSchoolSuppliesID())){
                    response.sendRedirect("addQuantity?id=" + list.get(i).getBillDetailID());
                    return;
                }
            }
            BillDetail billDetail = new BillDetail(schoolsupplies.getSchoolSuppliesID(),account.getAccountID(), schoolsupplies.getSchoolSuppliesName(),
                    schoolsupplies.getSchoolSuppliesImage(), schoolsupplies.getSchoolSuppliesPrice(), 1);
            int n = accountDAO.insertBillDetail(billDetail);
            response.sendRedirect("cart.jsp");
        } catch (Exception ex) {
            Logger.getLogger(CartServlet.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
