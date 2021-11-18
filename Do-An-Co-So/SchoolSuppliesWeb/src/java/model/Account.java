/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author HEALER
 */
public class Account {

    private int accountID;
    private String accountName;
    private String accountEmail;
    private String accountPass;
    private String accountPhone;

    public Account(int accountID) {
        this.accountID = accountID;
    }

    public Account(int accountID, String accountName, String accountEmail, String accountPass, String accountPhone) {
        this.accountID = accountID;
        this.accountName = accountName;
        this.accountEmail = accountEmail;
        this.accountPass = accountPass;
        this.accountPhone = accountPhone;
    }

    public Account(String accountName, String accountEmail, String accountPass, String accountPhone) {
        this.accountName = accountName;
        this.accountEmail = accountEmail;
        this.accountPass = accountPass;
        this.accountPhone = accountPhone;
    }

    public Account() {
    }

    public int getAccountID() {
        return accountID;
    }

    public void setAccountID(int accountID) {
        this.accountID = accountID;
    }

    public String getAccountName() {
        return accountName;
    }

    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    public String getAccountEmail() {
        return accountEmail;
    }

    public void setAccountEmail(String accountEmail) {
        this.accountEmail = accountEmail;
    }

    public String getAccountPass() {
        return accountPass;
    }

    public void setAccountPass(String accountPass) {
        this.accountPass = accountPass;
    }

    public String getAccountPhone() {
        return accountPhone;
    }

    public void setAccountPhone(String accountPhone) {
        this.accountPhone = accountPhone;
    }

}
