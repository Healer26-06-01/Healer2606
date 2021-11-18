package context;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import model.Account;
import model.AdminAccount;
import model.Bill;
import model.BillDetail;
import model.SchoolSupplies;
import model.Category;
import model.Contact;

public class AccountDAO extends DBContext {

    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;

    public Account getAccount(String userName, String password) throws Exception {
        Account account = null;
        String sql = "SELECT * FROM Account WHERE account_name=? and account_pass=?";
        try {
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setString(1, userName);
            ps.setString(2, password);
            rs = ps.executeQuery();
            while (rs.next()) {
                int accountID = rs.getInt("account_id");
                String accountName = rs.getString("account_name");
                String accountEmail = rs.getString("account_email");
                String accountPass = rs.getString("account_pass");
                String accountPhone = rs.getString("account_phone");
                account = new Account(accountID, accountName, accountEmail, accountPass, accountPhone);
            }
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return account;
    }

    public Account getAccountByUsername(String userName) throws Exception {
        Account account = null;
        String sql = "SELECT * FROM Account WHERE account_name=?";
        try {
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setString(1, userName);
            rs = ps.executeQuery();
            while (rs.next()) {
                int accountID = rs.getInt("account_id");
                String accountName = rs.getString("account_name");
                String accountEmail = rs.getString("account_email");
                String accountPass = rs.getString("account_pass");
                String accountPhone = rs.getString("account_phone");
                account = new Account(accountID, accountName, accountEmail, accountPass, accountPhone);
            }
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return account;

    }

    public int addAccount(Account a) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("insert into Account values(?,?,?,?)");
            ps.setString(1, a.getAccountName());
            ps.setString(2, a.getAccountEmail());
            ps.setString(3, a.getAccountPass());
            ps.setString(4, a.getAccountPhone());
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public ArrayList<Category> getListCategory() throws Exception {
        try {
            String sql = "SELECT * FROM category";
            con = getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            ArrayList<Category> list = new ArrayList<>();
            while (rs.next()) {
                Category category = new Category();
                category.setCategoryID(rs.getInt("category_id"));
                category.setCategoryName(rs.getString("category_name"));
                list.add(category);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public ArrayList<SchoolSupplies> getListSchoolSuppliesByCategory(String id) throws Exception {
        try {
            String sql = "SELECT * FROM SchoolSupplies where category_id = ?";
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setString(1, id);
            rs = ps.executeQuery();
            ArrayList<SchoolSupplies> list = new ArrayList<>();
            while (rs.next()) {
                SchoolSupplies schoolsupplies = new SchoolSupplies();
                schoolsupplies.setSchoolSuppliesID(rs.getString("schoolsupplies_id"));
                schoolsupplies.setCategoryID(rs.getInt("category_id"));
                schoolsupplies.setSchoolSuppliesName(rs.getString("schoolsupplies_name"));
                schoolsupplies.setSchoolSuppliesImage(rs.getString("schoolsupplies_image"));
                schoolsupplies.setSchoolSuppliesPrice(rs.getLong("schoolsupplies_price"));
                schoolsupplies.setSchoolSuppliesDescription(rs.getString("schoolsupplies_description"));
                list.add(schoolsupplies);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public ArrayList<SchoolSupplies> getListSearchSchoolSupplies(String name) throws Exception {
        try {
            String sql = "SELECT * FROM SchoolSupplies where schoolsupplies_name like '%" + name + "%'";
            con = getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            ArrayList<SchoolSupplies> list = new ArrayList<>();
            while (rs.next()) {
                SchoolSupplies schoolsupplies = new SchoolSupplies();
                schoolsupplies.setSchoolSuppliesID(rs.getString("schoolsupplies_id"));
                schoolsupplies.setCategoryID(rs.getInt("category_id"));
                schoolsupplies.setSchoolSuppliesName(rs.getString("schoolsupplies_name"));
                schoolsupplies.setSchoolSuppliesImage(rs.getString("schoolsupplies_image"));
                schoolsupplies.setSchoolSuppliesPrice(rs.getLong("schoolsupplies_price"));
                schoolsupplies.setSchoolSuppliesDescription(rs.getString("schoolsupplies_description"));
                list.add(schoolsupplies);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public SchoolSupplies getSchoolSuppliesById(String id) throws Exception {
        SchoolSupplies schoolsupplies = new SchoolSupplies();
        String sql = "SELECT * FROM SchoolSupplies WHERE schoolsupplies_id=?";
        try {
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setString(1, id);
            rs = ps.executeQuery();
            while (rs.next()) {
                String schoolsuppliesID = rs.getString("schoolsupplies_id");
                int categoryID = rs.getInt("category_id");
                String schoolsuppliesName = rs.getString("schoolsupplies_name");
                String schoolsuppliesImage = rs.getString("schoolsupplies_image");
                long schoolsuppliesPrice = rs.getLong("schoolsupplies_price");
                String schoolsuppliesDescription = rs.getString("schoolsupplies_description");
                schoolsupplies = new SchoolSupplies(schoolsuppliesID, categoryID, schoolsuppliesName, schoolsuppliesImage, schoolsuppliesPrice, schoolsuppliesDescription);
            }
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return schoolsupplies;
    }

    public ArrayList<SchoolSupplies> getTop6ListNewSchoolSupplies() throws Exception {
        try {
            String sql = "select top(6) * from SchoolSupplies order by schoolsupplies_id desc";
            con = getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            ArrayList<SchoolSupplies> list = new ArrayList<>();
            while (rs.next()) {
                SchoolSupplies schoolsupplies = new SchoolSupplies();
                schoolsupplies.setSchoolSuppliesID(rs.getString("schoolsupplies_id"));
                schoolsupplies.setCategoryID(rs.getInt("category_id"));
                schoolsupplies.setSchoolSuppliesName(rs.getString("schoolsupplies_name"));
                schoolsupplies.setSchoolSuppliesImage(rs.getString("schoolsupplies_image"));
                schoolsupplies.setSchoolSuppliesPrice(rs.getLong("schoolsupplies_price"));
                schoolsupplies.setSchoolSuppliesDescription(rs.getString("schoolsupplies_description"));
                list.add(schoolsupplies);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public ArrayList<SchoolSupplies> getTop6ListSchoolSupplies(int categoryId) throws Exception {
        try {
            String sql = "select top(6) * from SchoolSupplies where category_id = ?";
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setInt(1, categoryId);
            rs = ps.executeQuery();
            ArrayList<SchoolSupplies> list = new ArrayList<>();
            while (rs.next()) {
                SchoolSupplies schoolsupplies = new SchoolSupplies();
                schoolsupplies.setSchoolSuppliesID(rs.getString("schoolsupplies_id"));
                schoolsupplies.setCategoryID(rs.getInt("category_id"));
                schoolsupplies.setSchoolSuppliesName(rs.getString("schoolsupplies_name"));
                schoolsupplies.setSchoolSuppliesImage(rs.getString("schoolsupplies_image"));
                schoolsupplies.setSchoolSuppliesPrice(rs.getLong("schoolsupplies_price"));
                schoolsupplies.setSchoolSuppliesDescription(rs.getString("schoolsupplies_description"));
                list.add(schoolsupplies);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public int insertBillDetail(BillDetail bill) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("insert into BillDetails values(?,?,?,?,?,?)");
            ps.setString(1, bill.getSchoolSuppliesID());
            ps.setInt(2, bill.getAccountID());
            ps.setString(3, bill.getSchoolSuppliesName());
            ps.setString(4, bill.getSchoolSuppliesImage());
            ps.setLong(5, bill.getPrice());
            ps.setInt(6, bill.getQuantity());
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int deleteBillDetail(int billDetailId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("delete from BillDetails where bill_detail_id = ?");
            ps.setInt(1, billDetailId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int addQuantity(int billDetailId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("update BillDetails set quantity = quantity+1 where bill_detail_id = ?");
            ps.setInt(1, billDetailId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public ArrayList<BillDetail> getListBillDetail(int accountId) throws Exception {
        try {
            String sql = "SELECT * FROM BillDetails where account_id = ?";
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setInt(1, accountId);
            rs = ps.executeQuery();
            ArrayList<BillDetail> list = new ArrayList<>();
            while (rs.next()) {
                BillDetail billDetail = new BillDetail();
                billDetail.setBillDetailID(rs.getInt("bill_detail_id"));
                billDetail.setSchoolSuppliesID(rs.getString("schoolsupplies_id"));
                billDetail.setAccountID(rs.getInt("account_id"));
                billDetail.setSchoolSuppliesName(rs.getString("schoolsupplies_name"));
                billDetail.setSchoolSuppliesImage(rs.getString("schoolsupplies_image"));
                billDetail.setPrice(rs.getLong("price"));
                billDetail.setQuantity(rs.getInt("quantity"));
                list.add(billDetail);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public BillDetail getBillDetail(int billDetailId) throws Exception {
        try {
            String sql = "SELECT * FROM BillDetails where bill_detail_id = ?";
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setInt(1, billDetailId);
            rs = ps.executeQuery();
            BillDetail billDetail = new BillDetail();
            while (rs.next()) {
                billDetail.setBillDetailID(rs.getInt("bill_detail_id"));
                billDetail.setSchoolSuppliesID(rs.getString("schoolsupplies_id"));
                billDetail.setAccountID(rs.getInt("account_id"));
                billDetail.setSchoolSuppliesName(rs.getString("schoolsupplies_name"));
                billDetail.setSchoolSuppliesImage(rs.getString("schoolsupplies_image"));
                billDetail.setPrice(rs.getLong("price"));
                billDetail.setQuantity(rs.getInt("quantity"));
            }
            return billDetail;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public int subQuantity(int billDetailId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("update BillDetails set quantity = quantity-1 where bill_detail_id = ?");
            ps.setInt(1, billDetailId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int insertBill(Bill bill) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("insert into Bill values(?,?,?,?,?,?,?)");
            ps.setInt(1, bill.getAccountID());
            ps.setLong(2, bill.getTotal());
            ps.setString(3, bill.getPayment());
            ps.setString(4, bill.getAddress());
            ps.setDate(5, bill.getDate());
            ps.setString(6, bill.getName());
            ps.setString(7, bill.getPhone());
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int deleteBill(int billId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("delete from Bill where bill_id = ?");
            ps.setInt(1, billId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int insertContact(Contact contact) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("insert into Contact values(?,?,?,?,?)");
            ps.setString(1, contact.getContactName());
            ps.setString(2, contact.getContactEmail());
            ps.setString(3, contact.getContactTitle());
            ps.setString(4, contact.getContactMessage());
            ps.setDate(5, contact.getContactDate());
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int editAccount(Account account) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("update Account set "
                    + "account_name=?,"
                    + "account_email=?,"
                    + "account_pass=?,"
                    + "account_phone=? where account_id = ?");
            ps.setString(1, account.getAccountName());
            ps.setString(2, account.getAccountEmail());
            ps.setString(3, account.getAccountPass());
            ps.setString(4, account.getAccountPhone());
            ps.setInt(5, account.getAccountID());
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public ArrayList<Account> getListAccount() throws Exception {
        try {
            String sql = "SELECT * FROM Account";
            con = getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            ArrayList<Account> list = new ArrayList<>();
            while (rs.next()) {
                Account account = new Account();
                account.setAccountID(rs.getInt(1));
                account.setAccountName(rs.getString(2));
                account.setAccountEmail(rs.getString(3));
                account.setAccountPass(rs.getString(4));
                account.setAccountPhone(rs.getString(5));
                list.add(account);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public AdminAccount getAdminAccount(String userName, String password) throws Exception {
        AdminAccount account = null;
        String sql = "SELECT * FROM UserAdmin WHERE account_name=? and account_pass=?";
        try {
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setString(1, userName);
            ps.setString(2, password);
            rs = ps.executeQuery();
            while (rs.next()) {
                int accountID = rs.getInt(1);
                String accountName = rs.getString(2);
                String accountPass = rs.getString(3);
                account = new AdminAccount(accountName, accountPass);
            }
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return account;

    }

    public int updateCategory(int categoryId, String categoryName) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("update Category set category_name = N'" + categoryName + "' where category_id = ?");
            ps.setInt(1, categoryId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int insertCategory(String categoryName) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("insert into Category values(?)");
            ps.setString(1, categoryName);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int deleteCategory(int categoryId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("delete from Category where category_id = ?");
            ps.setInt(1, categoryId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public ArrayList<SchoolSupplies> getListAllSchoolSupplies() throws Exception {
        try {
            String sql = "SELECT * FROM SchoolSupplies";
            con = getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            ArrayList<SchoolSupplies> list = new ArrayList<>();
            while (rs.next()) {
                SchoolSupplies schoolsupplies = new SchoolSupplies();
                schoolsupplies.setSchoolSuppliesID(rs.getString("schoolsupplies_id"));
                schoolsupplies.setCategoryID(rs.getInt("category_id"));
                schoolsupplies.setSchoolSuppliesName(rs.getString("schoolsupplies_name"));
                schoolsupplies.setSchoolSuppliesImage(rs.getString("schoolsupplies_image"));
                schoolsupplies.setSchoolSuppliesPrice(rs.getLong("schoolsupplies_price"));
                schoolsupplies.setSchoolSuppliesDescription(rs.getString("schoolsupplies_description"));
                list.add(schoolsupplies);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public int editSchoolSupplies(SchoolSupplies schoolsupplies) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("update SchoolSupplies set "
                    + "category_id=?,"
                    + "schoolsupplies_name=?,"
                    + "schoolsupplies_image=?,"
                    + "schoolsupplies_price=?,"
                    + "schoolsupplies_description=?"
                    + " where schoolsupplies_id = ?");
            ps.setInt(1, schoolsupplies.getCategoryID());
            ps.setString(2, schoolsupplies.getSchoolSuppliesName());
            ps.setString(3, schoolsupplies.getSchoolSuppliesImage());
            ps.setLong(4, schoolsupplies.getSchoolSuppliesPrice());
            ps.setString(5, schoolsupplies.getSchoolSuppliesDescription());
            ps.setString(6, schoolsupplies.getSchoolSuppliesID());
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int insertSchoolSupplies(SchoolSupplies schoolsupplies) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("insert into SchoolSupplies values(?,?,?,?,?,?)");
            ps.setString(1, schoolsupplies.getSchoolSuppliesID());
            ps.setInt(2, schoolsupplies.getCategoryID());
            ps.setString(3, schoolsupplies.getSchoolSuppliesName());
            ps.setString(4, schoolsupplies.getSchoolSuppliesImage());
            ps.setLong(5, schoolsupplies.getSchoolSuppliesPrice());
            ps.setString(6, schoolsupplies.getSchoolSuppliesDescription());
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int deleteSchoolSupplies(String schoolsuppliesId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("delete from SchoolSupplies where schoolsupplies_id = ?");
            ps.setString(1, schoolsuppliesId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public int deleteAccount(int accountId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("delete from Account where account_id = ?");
            ps.setInt(1, accountId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public ArrayList<Bill> getListBill() throws Exception {
        try {
            String sql = "SELECT * FROM Bill";
            con = getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            ArrayList<Bill> list = new ArrayList<>();
            while (rs.next()) {
                Bill bill = new Bill();
                bill.setBillID(rs.getInt(1));
                bill.setAccountID(rs.getInt(2));
                bill.setTotal(rs.getLong(3));
                bill.setPayment(rs.getString(4));
                bill.setAddress(rs.getString(5));
                bill.setDate(rs.getDate(6));
                bill.setName(rs.getString(7));
                bill.setPhone(rs.getString(8));
                list.add(bill);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public ArrayList<Contact> getListContacts() throws Exception {
        try {
            String sql = "SELECT * FROM Contact";
            con = getConnection();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            ArrayList<Contact> list = new ArrayList<>();
            while (rs.next()) {
                Contact contact = new Contact();
                contact.setContactID(rs.getInt(1));
                contact.setContactName(rs.getString(2));
                contact.setContactEmail(rs.getString(3));
                contact.setContactTitle(rs.getString(4));
                contact.setContactMessage(rs.getString(5));
                contact.setContactDate(rs.getDate(6));
                list.add(contact);
            }
            return list;
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
    }

    public int deleteContact(int contactId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("delete from Contact where contact_id = ?");
            ps.setInt(1, contactId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }

    public Category getCategoryByName(String categoryName) throws Exception {
        Category category = null;
        String sql = "SELECT * FROM Category WHERE category_name=?";
        try {
            con = getConnection();
            ps = con.prepareStatement(sql);
            ps.setString(1, categoryName);
            rs = ps.executeQuery();
            while (rs.next()) {
                int categoryID = rs.getInt(1);
                String name = rs.getString(2);
                category = new Category(categoryID, name);
            }
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return category;

    }

    public int deleteBillDetailByAccountId(int accountId) throws Exception {
        int status = 0;
        try {
            con = getConnection();
            ps = con.prepareStatement("delete from BillDetails where account_id = ?");
            ps.setInt(1, accountId);
            status = ps.executeUpdate();
        } catch (Exception e) {
            throw e;
        } finally {
            closeResultSet(rs);
            closePreparedStatement(ps);
            closeConnection(con);
        }
        return status;
    }
}
