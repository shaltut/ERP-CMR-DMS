namespace VAdvantage.Model
{

/** Generated Model - DO NOT CHANGE */
using System;
using System.Text;
using VAdvantage.DataBase;
using VAdvantage.Common;
using VAdvantage.Classes;
using VAdvantage.Process;
using VAdvantage.Model;
using VAdvantage.Utility;
using System.Data;
/** Generated Model for C_Payment
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_C_Payment : PO
{
public X_C_Payment (Context ctx, int C_Payment_ID, Trx trxName) : base (ctx, C_Payment_ID, trxName)
{
/** if (C_Payment_ID == 0)
{
SetC_BankAccount_ID (0);
SetC_Currency_ID (0);
SetC_DocType_ID (0);
SetC_Payment_ID (0);
SetDateAcct (DateTime.Now);	// @#Date@
SetDateTrx (DateTime.Now);	// @#Date@
SetDocAction (null);	// CO
SetDocStatus (null);	// DR
SetDocumentNo (null);
SetIsAllocated (false);
SetIsApproved (false);	// N
SetIsDelayedCapture (false);
SetIsOnline (false);
SetIsOverUnderPayment (false);	// N
SetIsPrepayment (false);
SetIsReceipt (false);
SetIsReconciled (false);
SetIsSelfService (false);
SetPayAmt (0.0);	// 0
SetPosted (false);	// N
SetProcessed (false);	// N
SetTenderType (null);	// K
SetTrxType (null);	// S
}
 */
}
public X_C_Payment (Ctx ctx, int C_Payment_ID, Trx trxName) : base (ctx, C_Payment_ID, trxName)
{
/** if (C_Payment_ID == 0)
{
SetC_BankAccount_ID (0);
SetC_Currency_ID (0);
SetC_DocType_ID (0);
SetC_Payment_ID (0);
SetDateAcct (DateTime.Now);	// @#Date@
SetDateTrx (DateTime.Now);	// @#Date@
SetDocAction (null);	// CO
SetDocStatus (null);	// DR
SetDocumentNo (null);
SetIsAllocated (false);
SetIsApproved (false);	// N
SetIsDelayedCapture (false);
SetIsOnline (false);
SetIsOverUnderPayment (false);	// N
SetIsPrepayment (false);
SetIsReceipt (false);
SetIsReconciled (false);
SetIsSelfService (false);
SetPayAmt (0.0);	// 0
SetPosted (false);	// N
SetProcessed (false);	// N
SetTenderType (null);	// K
SetTrxType (null);	// S
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Payment (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Payment (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Payment (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_C_Payment()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514373692L;
/** Last Updated Timestamp 7/29/2010 1:07:36 PM */
public static long updatedMS = 1280389056903L;
/** AD_Table_ID=335 */
public static int Table_ID;
 // =335;

/** TableName=C_Payment */
public static String Table_Name="C_Payment";

protected static KeyNamePair model;
protected Decimal accessLevel = new Decimal(1);
/** AccessLevel
@return 1 - Org 
*/
protected override int Get_AccessLevel()
{
return Convert.ToInt32(accessLevel.ToString());
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Ctx ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Context ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Info
@return info
*/
public override String ToString()
{
StringBuilder sb = new StringBuilder ("X_C_Payment[").Append(Get_ID()).Append("]");
return sb.ToString();
}

/** AD_OrgTrx_ID AD_Reference_ID=130 */
public static int AD_ORGTRX_ID_AD_Reference_ID=130;
/** Set Trx Organization.
@param AD_OrgTrx_ID Performing or initiating organization */
public void SetAD_OrgTrx_ID (int AD_OrgTrx_ID)
{
if (AD_OrgTrx_ID <= 0) Set_Value ("AD_OrgTrx_ID", null);
else
Set_Value ("AD_OrgTrx_ID", AD_OrgTrx_ID);
}
/** Get Trx Organization.
@return Performing or initiating organization */
public int GetAD_OrgTrx_ID() 
{
Object ii = Get_Value("AD_OrgTrx_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Account City.
@param A_City City or the Credit Card or Account Holder */
public void SetA_City (String A_City)
{
if (A_City != null && A_City.Length > 60)
{
log.Warning("Length > 60 - truncated");
A_City = A_City.Substring(0,60);
}
Set_Value ("A_City", A_City);
}
/** Get Account City.
@return City or the Credit Card or Account Holder */
public String GetA_City() 
{
return (String)Get_Value("A_City");
}
/** Set Account Country.
@param A_Country Country */
public void SetA_Country (String A_Country)
{
if (A_Country != null && A_Country.Length > 40)
{
log.Warning("Length > 40 - truncated");
A_Country = A_Country.Substring(0,40);
}
Set_Value ("A_Country", A_Country);
}
/** Get Account Country.
@return Country */
public String GetA_Country() 
{
return (String)Get_Value("A_Country");
}
/** Set Account EMail.
@param A_EMail Email Address */
public void SetA_EMail (String A_EMail)
{
if (A_EMail != null && A_EMail.Length > 60)
{
log.Warning("Length > 60 - truncated");
A_EMail = A_EMail.Substring(0,60);
}
Set_Value ("A_EMail", A_EMail);
}
/** Get Account EMail.
@return Email Address */
public String GetA_EMail() 
{
return (String)Get_Value("A_EMail");
}
/** Set Driver License.
@param A_Ident_DL Payment Identification - Driver License */
public void SetA_Ident_DL (String A_Ident_DL)
{
if (A_Ident_DL != null && A_Ident_DL.Length > 20)
{
log.Warning("Length > 20 - truncated");
A_Ident_DL = A_Ident_DL.Substring(0,20);
}
Set_Value ("A_Ident_DL", A_Ident_DL);
}
/** Get Driver License.
@return Payment Identification - Driver License */
public String GetA_Ident_DL() 
{
return (String)Get_Value("A_Ident_DL");
}
/** Set Social Security No.
@param A_Ident_SSN Payment Identification - Social Security No */
public void SetA_Ident_SSN (String A_Ident_SSN)
{
if (A_Ident_SSN != null && A_Ident_SSN.Length > 20)
{
log.Warning("Length > 20 - truncated");
A_Ident_SSN = A_Ident_SSN.Substring(0,20);
}
Set_Value ("A_Ident_SSN", A_Ident_SSN);
}
/** Get Social Security No.
@return Payment Identification - Social Security No */
public String GetA_Ident_SSN() 
{
return (String)Get_Value("A_Ident_SSN");
}
/** Set Account Name.
@param A_Name Name on Credit Card or Account holder */
public void SetA_Name (String A_Name)
{
if (A_Name != null && A_Name.Length > 60)
{
log.Warning("Length > 60 - truncated");
A_Name = A_Name.Substring(0,60);
}
Set_Value ("A_Name", A_Name);
}
/** Get Account Name.
@return Name on Credit Card or Account holder */
public String GetA_Name() 
{
return (String)Get_Value("A_Name");
}
/** Set Account State.
@param A_State State of the Credit Card or Account holder */
public void SetA_State (String A_State)
{
if (A_State != null && A_State.Length > 40)
{
log.Warning("Length > 40 - truncated");
A_State = A_State.Substring(0,40);
}
Set_Value ("A_State", A_State);
}
/** Get Account State.
@return State of the Credit Card or Account holder */
public String GetA_State() 
{
return (String)Get_Value("A_State");
}
/** Set Account Street.
@param A_Street Street address of the Credit Card or Account holder */
public void SetA_Street (String A_Street)
{
if (A_Street != null && A_Street.Length > 60)
{
log.Warning("Length > 60 - truncated");
A_Street = A_Street.Substring(0,60);
}
Set_Value ("A_Street", A_Street);
}
/** Get Account Street.
@return Street address of the Credit Card or Account holder */
public String GetA_Street() 
{
return (String)Get_Value("A_Street");
}
/** Set Account Zip/Postal.
@param A_Zip Zip Code of the Credit Card or Account Holder */
public void SetA_Zip (String A_Zip)
{
if (A_Zip != null && A_Zip.Length > 20)
{
log.Warning("Length > 20 - truncated");
A_Zip = A_Zip.Substring(0,20);
}
Set_Value ("A_Zip", A_Zip);
}
/** Get Account Zip/Postal.
@return Zip Code of the Credit Card or Account Holder */
public String GetA_Zip() 
{
return (String)Get_Value("A_Zip");
}
/** Set Account No.
@param AccountNo Account Number */
public void SetAccountNo (String AccountNo)
{
if (AccountNo != null && AccountNo.Length > 20)
{
log.Warning("Length > 20 - truncated");
AccountNo = AccountNo.Substring(0,20);
}
Set_Value ("AccountNo", AccountNo);
}
/** Get Account No.
@return Account Number */
public String GetAccountNo() 
{
return (String)Get_Value("AccountNo");
}
/** Set Activity.
@param C_Activity_ID Business Activity */
public void SetC_Activity_ID (int C_Activity_ID)
{
if (C_Activity_ID <= 0) Set_Value ("C_Activity_ID", null);
else
Set_Value ("C_Activity_ID", C_Activity_ID);
}
/** Get Activity.
@return Business Activity */
public int GetC_Activity_ID() 
{
Object ii = Get_Value("C_Activity_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Partner Bank Account.
@param C_BP_BankAccount_ID Bank Account of the Business Partner */
public void SetC_BP_BankAccount_ID (int C_BP_BankAccount_ID)
{
if (C_BP_BankAccount_ID <= 0) Set_Value ("C_BP_BankAccount_ID", null);
else
Set_Value ("C_BP_BankAccount_ID", C_BP_BankAccount_ID);
}
/** Get Partner Bank Account.
@return Bank Account of the Business Partner */
public int GetC_BP_BankAccount_ID() 
{
Object ii = Get_Value("C_BP_BankAccount_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Business Partner.
@param C_BPartner_ID Identifies a Business Partner */
public void SetC_BPartner_ID (int C_BPartner_ID)
{
if (C_BPartner_ID <= 0) Set_Value ("C_BPartner_ID", null);
else
Set_Value ("C_BPartner_ID", C_BPartner_ID);
}
/** Get Business Partner.
@return Identifies a Business Partner */
public int GetC_BPartner_ID() 
{
Object ii = Get_Value("C_BPartner_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Bank Account.
@param C_BankAccount_ID Account at the Bank */
public void SetC_BankAccount_ID (int C_BankAccount_ID)
{
if (C_BankAccount_ID < 1) throw new ArgumentException ("C_BankAccount_ID is mandatory.");
Set_Value ("C_BankAccount_ID", C_BankAccount_ID);
}
/** Get Bank Account.
@return Account at the Bank */
public int GetC_BankAccount_ID() 
{
Object ii = Get_Value("C_BankAccount_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Campaign.
@param C_Campaign_ID Marketing Campaign */
public void SetC_Campaign_ID (int C_Campaign_ID)
{
if (C_Campaign_ID <= 0) Set_Value ("C_Campaign_ID", null);
else
Set_Value ("C_Campaign_ID", C_Campaign_ID);
}
/** Get Campaign.
@return Marketing Campaign */
public int GetC_Campaign_ID() 
{
Object ii = Get_Value("C_Campaign_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Charge.
@param C_Charge_ID Additional document charges */
public void SetC_Charge_ID (int C_Charge_ID)
{
if (C_Charge_ID <= 0) Set_Value ("C_Charge_ID", null);
else
Set_Value ("C_Charge_ID", C_Charge_ID);
}
/** Get Charge.
@return Additional document charges */
public int GetC_Charge_ID() 
{
Object ii = Get_Value("C_Charge_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Currency Type.
@param C_ConversionType_ID Currency Conversion Rate Type */
public void SetC_ConversionType_ID (int C_ConversionType_ID)
{
if (C_ConversionType_ID <= 0) Set_Value ("C_ConversionType_ID", null);
else
Set_Value ("C_ConversionType_ID", C_ConversionType_ID);
}
/** Get Currency Type.
@return Currency Conversion Rate Type */
public int GetC_ConversionType_ID() 
{
Object ii = Get_Value("C_ConversionType_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Currency.
@param C_Currency_ID The Currency for this record */
public void SetC_Currency_ID (int C_Currency_ID)
{
if (C_Currency_ID < 1) throw new ArgumentException ("C_Currency_ID is mandatory.");
Set_Value ("C_Currency_ID", C_Currency_ID);
}
/** Get Currency.
@return The Currency for this record */
public int GetC_Currency_ID() 
{
Object ii = Get_Value("C_Currency_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Document Type.
@param C_DocType_ID Document type or rules */
public void SetC_DocType_ID (int C_DocType_ID)
{
if (C_DocType_ID < 0) throw new ArgumentException ("C_DocType_ID is mandatory.");
Set_Value ("C_DocType_ID", C_DocType_ID);
}
/** Get Document Type.
@return Document type or rules */
public int GetC_DocType_ID() 
{
Object ii = Get_Value("C_DocType_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Invoice.
@param C_Invoice_ID Invoice Identifier */
public void SetC_Invoice_ID (int C_Invoice_ID)
{
if (C_Invoice_ID <= 0) Set_Value ("C_Invoice_ID", null);
else
Set_Value ("C_Invoice_ID", C_Invoice_ID);
}
/** Get Invoice.
@return Invoice Identifier */
public int GetC_Invoice_ID() 
{
Object ii = Get_Value("C_Invoice_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Order.
@param C_Order_ID Order */
public void SetC_Order_ID (int C_Order_ID)
{
if (C_Order_ID <= 0) Set_Value ("C_Order_ID", null);
else
Set_Value ("C_Order_ID", C_Order_ID);
}
/** Get Order.
@return Order */
public int GetC_Order_ID() 
{
Object ii = Get_Value("C_Order_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Payment Batch.
@param C_PaymentBatch_ID Payment batch for EFT */
public void SetC_PaymentBatch_ID (int C_PaymentBatch_ID)
{
if (C_PaymentBatch_ID <= 0) Set_Value ("C_PaymentBatch_ID", null);
else
Set_Value ("C_PaymentBatch_ID", C_PaymentBatch_ID);
}
/** Get Payment Batch.
@return Payment batch for EFT */
public int GetC_PaymentBatch_ID() 
{
Object ii = Get_Value("C_PaymentBatch_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Payment.
@param C_Payment_ID Payment identifier */
public void SetC_Payment_ID (int C_Payment_ID)
{
if (C_Payment_ID < 1) throw new ArgumentException ("C_Payment_ID is mandatory.");
Set_ValueNoCheck ("C_Payment_ID", C_Payment_ID);
}
/** Get Payment.
@return Payment identifier */
public int GetC_Payment_ID() 
{
Object ii = Get_Value("C_Payment_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Project.
@param C_Project_ID Financial Project */
public void SetC_Project_ID (int C_Project_ID)
{
if (C_Project_ID <= 0) Set_Value ("C_Project_ID", null);
else
Set_Value ("C_Project_ID", C_Project_ID);
}
/** Get Project.
@return Financial Project */
public int GetC_Project_ID() 
{
Object ii = Get_Value("C_Project_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Charge amount.
@param ChargeAmt Charge Amount */
public void SetChargeAmt (Decimal? ChargeAmt)
{
Set_Value ("ChargeAmt", (Decimal?)ChargeAmt);
}
/** Get Charge amount.
@return Charge Amount */
public Decimal GetChargeAmt() 
{
Object bd =Get_Value("ChargeAmt");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Check No.
@param CheckNo Check Number */
public void SetCheckNo (String CheckNo)
{
if (CheckNo != null && CheckNo.Length > 20)
{
log.Warning("Length > 20 - truncated");
CheckNo = CheckNo.Substring(0,20);
}
Set_Value ("CheckNo", CheckNo);
}
/** Get Check No.
@return Check Number */
public String GetCheckNo() 
{
return (String)Get_Value("CheckNo");
}
/** Set Check Date.
@param CheckDate Check Date */
public void SetCheckDate(DateTime? CheckDate)
{
    Set_Value("CheckDate", (DateTime?)CheckDate);
}
/** Get Check Date.
@return Check Date */
public DateTime? GetCheckDate()
{
    return (DateTime?)Get_Value("CheckDate");
}
/** Set Exp. Month.
@param CreditCardExpMM Expiry Month */
public void SetCreditCardExpMM (int CreditCardExpMM)
{
Set_Value ("CreditCardExpMM", CreditCardExpMM);
}
/** Get Exp. Month.
@return Expiry Month */
public int GetCreditCardExpMM() 
{
Object ii = Get_Value("CreditCardExpMM");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Exp. Year.
@param CreditCardExpYY Expiry Year */
public void SetCreditCardExpYY (int CreditCardExpYY)
{
Set_Value ("CreditCardExpYY", CreditCardExpYY);
}
/** Get Exp. Year.
@return Expiry Year */
public int GetCreditCardExpYY() 
{
Object ii = Get_Value("CreditCardExpYY");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Number.
@param CreditCardNumber Credit Card Number */
public void SetCreditCardNumber (String CreditCardNumber)
{
if (CreditCardNumber != null && CreditCardNumber.Length > 20)
{
log.Warning("Length > 20 - truncated");
CreditCardNumber = CreditCardNumber.Substring(0,20);
}
Set_Value ("CreditCardNumber", CreditCardNumber);
}
/** Get Number.
@return Credit Card Number */
public String GetCreditCardNumber() 
{
return (String)Get_Value("CreditCardNumber");
}

/** CreditCardType AD_Reference_ID=149 */
public static int CREDITCARDTYPE_AD_Reference_ID=149;
/** Amex = A */
public static String CREDITCARDTYPE_Amex = "A";
/** ATM = C */
public static String CREDITCARDTYPE_ATM = "C";
/** Diners = D */
public static String CREDITCARDTYPE_Diners = "D";
/** MasterCard = M */
public static String CREDITCARDTYPE_MasterCard = "M";
/** Discover = N */
public static String CREDITCARDTYPE_Discover = "N";
/** Purchase Card = P */
public static String CREDITCARDTYPE_PurchaseCard = "P";
/** Visa = V */
public static String CREDITCARDTYPE_Visa = "V";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsCreditCardTypeValid (String test)
{
return test == null || test.Equals("A") || test.Equals("C") || test.Equals("D") || test.Equals("M") || test.Equals("N") || test.Equals("P") || test.Equals("V");
}
/** Set Credit Card.
@param CreditCardType Credit Card (Visa, MC, AmEx) */
public void SetCreditCardType (String CreditCardType)
{
if (!IsCreditCardTypeValid(CreditCardType))
throw new ArgumentException ("CreditCardType Invalid value - " + CreditCardType + " - Reference_ID=149 - A - C - D - M - N - P - V");
if (CreditCardType != null && CreditCardType.Length > 1)
{
log.Warning("Length > 1 - truncated");
CreditCardType = CreditCardType.Substring(0,1);
}
Set_Value ("CreditCardType", CreditCardType);
}
/** Get Credit Card.
@return Credit Card (Visa, MC, AmEx) */
public String GetCreditCardType() 
{
return (String)Get_Value("CreditCardType");
}
/** Set Account Date.
@param DateAcct General Ledger Date */
public void SetDateAcct (DateTime? DateAcct)
{
if (DateAcct == null) throw new ArgumentException ("DateAcct is mandatory.");
Set_Value ("DateAcct", (DateTime?)DateAcct);
}
/** Get Account Date.
@return General Ledger Date */
public DateTime? GetDateAcct() 
{
return (DateTime?)Get_Value("DateAcct");
}
/** Set Transaction Date.
@param DateTrx Transaction Date */
public void SetDateTrx (DateTime? DateTrx)
{
if (DateTrx == null) throw new ArgumentException ("DateTrx is mandatory.");
Set_Value ("DateTrx", (DateTime?)DateTrx);
}
/** Get Transaction Date.
@return Transaction Date */
public DateTime? GetDateTrx() 
{
return (DateTime?)Get_Value("DateTrx");
}
/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description)
{
if (Description != null && Description.Length > 255)
{
log.Warning("Length > 255 - truncated");
Description = Description.Substring(0,255);
}
Set_Value ("Description", Description);
}
/** Get Description.
@return Optional short description of the record */
public String GetDescription() 
{
return (String)Get_Value("Description");
}
/** Set Discount Amount.
@param DiscountAmt Calculated amount of discount */
public void SetDiscountAmt (Decimal? DiscountAmt)
{
Set_Value ("DiscountAmt", (Decimal?)DiscountAmt);
}
/** Get Discount Amount.
@return Calculated amount of discount */
public Decimal GetDiscountAmt() 
{
Object bd =Get_Value("DiscountAmt");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}

/** DocAction AD_Reference_ID=135 */
public static int DOCACTION_AD_Reference_ID=135;
/** <None> = -- */
public static String DOCACTION_None = "--";
/** Approve = AP */
public static String DOCACTION_Approve = "AP";
/** Close = CL */
public static String DOCACTION_Close = "CL";
/** Complete = CO */
public static String DOCACTION_Complete = "CO";
/** Invalidate = IN */
public static String DOCACTION_Invalidate = "IN";
/** Post = PO */
public static String DOCACTION_Post = "PO";
/** Prepare = PR */
public static String DOCACTION_Prepare = "PR";
/** Reverse - Accrual = RA */
public static String DOCACTION_Reverse_Accrual = "RA";
/** Reverse - Correct = RC */
public static String DOCACTION_Reverse_Correct = "RC";
/** Re-activate = RE */
public static String DOCACTION_Re_Activate = "RE";
/** Reject = RJ */
public static String DOCACTION_Reject = "RJ";
/** Void = VO */
public static String DOCACTION_Void = "VO";
/** Wait Complete = WC */
public static String DOCACTION_WaitComplete = "WC";
/** Unlock = XL */
public static String DOCACTION_Unlock = "XL";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsDocActionValid (String test)
{
return test.Equals("--") || test.Equals("AP") || test.Equals("CL") || test.Equals("CO") || test.Equals("IN") || test.Equals("PO") || test.Equals("PR") || test.Equals("RA") || test.Equals("RC") || test.Equals("RE") || test.Equals("RJ") || test.Equals("VO") || test.Equals("WC") || test.Equals("XL");
}
/** Set Document Action.
@param DocAction The targeted status of the document */
public void SetDocAction (String DocAction)
{
if (DocAction == null) throw new ArgumentException ("DocAction is mandatory");
if (!IsDocActionValid(DocAction))
throw new ArgumentException ("DocAction Invalid value - " + DocAction + " - Reference_ID=135 - -- - AP - CL - CO - IN - PO - PR - RA - RC - RE - RJ - VO - WC - XL");
if (DocAction.Length > 2)
{
log.Warning("Length > 2 - truncated");
DocAction = DocAction.Substring(0,2);
}
Set_Value ("DocAction", DocAction);
}
/** Get Document Action.
@return The targeted status of the document */
public String GetDocAction() 
{
return (String)Get_Value("DocAction");
}

/** DocStatus AD_Reference_ID=131 */
public static int DOCSTATUS_AD_Reference_ID=131;
/** Unknown = ?? */
public static String DOCSTATUS_Unknown = "??";
/** Approved = AP */
public static String DOCSTATUS_Approved = "AP";
/** Closed = CL */
public static String DOCSTATUS_Closed = "CL";
/** Completed = CO */
public static String DOCSTATUS_Completed = "CO";
/** Drafted = DR */
public static String DOCSTATUS_Drafted = "DR";
/** Invalid = IN */
public static String DOCSTATUS_Invalid = "IN";
/** In Progress = IP */
public static String DOCSTATUS_InProgress = "IP";
/** Not Approved = NA */
public static String DOCSTATUS_NotApproved = "NA";
/** Reversed = RE */
public static String DOCSTATUS_Reversed = "RE";
/** Voided = VO */
public static String DOCSTATUS_Voided = "VO";
/** Waiting Confirmation = WC */
public static String DOCSTATUS_WaitingConfirmation = "WC";
/** Waiting Payment = WP */
public static String DOCSTATUS_WaitingPayment = "WP";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsDocStatusValid (String test)
{
return test.Equals("??") || test.Equals("AP") || test.Equals("CL") || test.Equals("CO") || test.Equals("DR") || test.Equals("IN") || test.Equals("IP") || test.Equals("NA") || test.Equals("RE") || test.Equals("VO") || test.Equals("WC") || test.Equals("WP");
}
/** Set Document Status.
@param DocStatus The current status of the document */
public void SetDocStatus (String DocStatus)
{
if (DocStatus == null) throw new ArgumentException ("DocStatus is mandatory");
if (!IsDocStatusValid(DocStatus))
throw new ArgumentException ("DocStatus Invalid value - " + DocStatus + " - Reference_ID=131 - ?? - AP - CL - CO - DR - IN - IP - NA - RE - VO - WC - WP");
if (DocStatus.Length > 2)
{
log.Warning("Length > 2 - truncated");
DocStatus = DocStatus.Substring(0,2);
}
Set_Value ("DocStatus", DocStatus);
}
/** Get Document Status.
@return The current status of the document */
public String GetDocStatus() 
{
return (String)Get_Value("DocStatus");
}
/** Set Document No.
@param DocumentNo Document sequence number of the document */
public void SetDocumentNo (String DocumentNo)
{
if (DocumentNo == null) throw new ArgumentException ("DocumentNo is mandatory.");
if (DocumentNo.Length > 30)
{
log.Warning("Length > 30 - truncated");
DocumentNo = DocumentNo.Substring(0,30);
}
Set_Value ("DocumentNo", DocumentNo);
}
/** Get Document No.
@return Document sequence number of the document */
public String GetDocumentNo() 
{
return (String)Get_Value("DocumentNo");
}
/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() 
{
return new KeyNamePair(Get_ID(), GetDocumentNo());
}
/** Set Allocated.
@param IsAllocated Indicates if the payment has been allocated */
public void SetIsAllocated (Boolean IsAllocated)
{
Set_Value ("IsAllocated", IsAllocated);
}
/** Get Allocated.
@return Indicates if the payment has been allocated */
public Boolean IsAllocated() 
{
Object oo = Get_Value("IsAllocated");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Approved.
@param IsApproved Indicates if this document requires approval */
public void SetIsApproved (Boolean IsApproved)
{
Set_ValueNoCheck ("IsApproved", IsApproved);
}
/** Get Approved.
@return Indicates if this document requires approval */
public Boolean IsApproved() 
{
Object oo = Get_Value("IsApproved");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Delayed Capture.
@param IsDelayedCapture Charge after Shipment */
public void SetIsDelayedCapture (Boolean IsDelayedCapture)
{
Set_Value ("IsDelayedCapture", IsDelayedCapture);
}
/** Get Delayed Capture.
@return Charge after Shipment */
public Boolean IsDelayedCapture() 
{
Object oo = Get_Value("IsDelayedCapture");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Online Access.
@param IsOnline Can be accessed online */
public void SetIsOnline (Boolean IsOnline)
{
Set_Value ("IsOnline", IsOnline);
}
/** Get Online Access.
@return Can be accessed online */
public Boolean IsOnline() 
{
Object oo = Get_Value("IsOnline");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Over/Under Payment.
@param IsOverUnderPayment Over-Payment (unallocated) or Under-Payment (partial payment) */
public void SetIsOverUnderPayment (Boolean IsOverUnderPayment)
{
Set_Value ("IsOverUnderPayment", IsOverUnderPayment);
}
/** Get Over/Under Payment.
@return Over-Payment (unallocated) or Under-Payment (partial payment) */
public Boolean IsOverUnderPayment() 
{
Object oo = Get_Value("IsOverUnderPayment");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Prepayment.
@param IsPrepayment The Payment/Receipt is a Prepayment */
public void SetIsPrepayment (Boolean IsPrepayment)
{
Set_Value ("IsPrepayment", IsPrepayment);
}
/** Get Prepayment.
@return The Payment/Receipt is a Prepayment */
public Boolean IsPrepayment() 
{
Object oo = Get_Value("IsPrepayment");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Receipt.
@param IsReceipt This is a sales transaction (receipt) */
public void SetIsReceipt (Boolean IsReceipt)
{
Set_Value ("IsReceipt", IsReceipt);
}
/** Get Receipt.
@return This is a sales transaction (receipt) */
public Boolean IsReceipt() 
{
Object oo = Get_Value("IsReceipt");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Reconciled.
@param IsReconciled Payment is reconciled with bank statement */
public void SetIsReconciled (Boolean IsReconciled)
{
Set_Value ("IsReconciled", IsReconciled);
}
/** Get Reconciled.
@return Payment is reconciled with bank statement */
public Boolean IsReconciled() 
{
Object oo = Get_Value("IsReconciled");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Self-Service.
@param IsSelfService This is a Self-Service entry or this entry can be changed via Self-Service */
public void SetIsSelfService (Boolean IsSelfService)
{
Set_Value ("IsSelfService", IsSelfService);
}
/** Get Self-Service.
@return This is a Self-Service entry or this entry can be changed via Self-Service */
public Boolean IsSelfService() 
{
Object oo = Get_Value("IsSelfService");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Micr.
@param Micr Combination of routing no, account and check no */
public void SetMicr (String Micr)
{
if (Micr != null && Micr.Length > 20)
{
log.Warning("Length > 20 - truncated");
Micr = Micr.Substring(0,20);
}
Set_Value ("Micr", Micr);
}
/** Get Micr.
@return Combination of routing no, account and check no */
public String GetMicr() 
{
return (String)Get_Value("Micr");
}
/** Set Online Processing.
@param OProcessing This payment can be processed online */
public void SetOProcessing (String OProcessing)
{
if (OProcessing != null && OProcessing.Length > 1)
{
log.Warning("Length > 1 - truncated");
OProcessing = OProcessing.Substring(0,1);
}
Set_Value ("OProcessing", OProcessing);
}
/** Get Online Processing.
@return This payment can be processed online */
public String GetOProcessing() 
{
return (String)Get_Value("OProcessing");
}
/** Set Original Transaction ID.
@param Orig_TrxID Original Transaction ID */
public void SetOrig_TrxID (String Orig_TrxID)
{
if (Orig_TrxID != null && Orig_TrxID.Length > 20)
{
log.Warning("Length > 20 - truncated");
Orig_TrxID = Orig_TrxID.Substring(0,20);
}
Set_Value ("Orig_TrxID", Orig_TrxID);
}
/** Get Original Transaction ID.
@return Original Transaction ID */
public String GetOrig_TrxID() 
{
return (String)Get_Value("Orig_TrxID");
}
/** Set Over/Under Payment.
@param OverUnderAmt Over-Payment (unallocated) or Under-Payment (partial payment) Amount */
public void SetOverUnderAmt (Decimal? OverUnderAmt)
{
Set_Value ("OverUnderAmt", (Decimal?)OverUnderAmt);
}
/** Get Over/Under Payment.
@return Over-Payment (unallocated) or Under-Payment (partial payment) Amount */
public Decimal GetOverUnderAmt() 
{
Object bd =Get_Value("OverUnderAmt");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set PO Number.
@param PONum Purchase Order Number */
public void SetPONum (String PONum)
{
if (PONum != null && PONum.Length > 60)
{
log.Warning("Length > 60 - truncated");
PONum = PONum.Substring(0,60);
}
Set_Value ("PONum", PONum);
}
/** Get PO Number.
@return Purchase Order Number */
public String GetPONum() 
{
return (String)Get_Value("PONum");
}
/** Set Payment amount.
@param PayAmt Amount being paid */
public void SetPayAmt (Decimal? PayAmt)
{
if (PayAmt == null) throw new ArgumentException ("PayAmt is mandatory.");
Set_Value ("PayAmt", (Decimal?)PayAmt);
}
/** Get Payment amount.
@return Amount being paid */
public Decimal GetPayAmt() 
{
Object bd =Get_Value("PayAmt");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Posted.
@param Posted Posting status */
public void SetPosted (Boolean Posted)
{
Set_Value ("Posted", Posted);
}
/** Get Posted.
@return Posting status */
public Boolean IsPosted() 
{
Object oo = Get_Value("Posted");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Processed.
@param Processed The document has been processed */
public void SetProcessed (Boolean Processed)
{
Set_Value ("Processed", Processed);
}
/** Get Processed.
@return The document has been processed */
public Boolean IsProcessed() 
{
Object oo = Get_Value("Processed");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Process Now.
@param Processing Process Now */
public void SetProcessing (Boolean Processing)
{
Set_Value ("Processing", Processing);
}
/** Get Process Now.
@return Process Now */
public Boolean IsProcessing() 
{
Object oo = Get_Value("Processing");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Authorization Code.
@param R_AuthCode Authorization Code returned */
public void SetR_AuthCode (String R_AuthCode)
{
if (R_AuthCode != null && R_AuthCode.Length > 20)
{
log.Warning("Length > 20 - truncated");
R_AuthCode = R_AuthCode.Substring(0,20);
}
Set_ValueNoCheck ("R_AuthCode", R_AuthCode);
}
/** Get Authorization Code.
@return Authorization Code returned */
public String GetR_AuthCode() 
{
return (String)Get_Value("R_AuthCode");
}
/** Set Authorization Code (DC).
@param R_AuthCode_DC Authorization Code Delayed Capture returned */
public void SetR_AuthCode_DC (String R_AuthCode_DC)
{
if (R_AuthCode_DC != null && R_AuthCode_DC.Length > 20)
{
log.Warning("Length > 20 - truncated");
R_AuthCode_DC = R_AuthCode_DC.Substring(0,20);
}
Set_ValueNoCheck ("R_AuthCode_DC", R_AuthCode_DC);
}
/** Get Authorization Code (DC).
@return Authorization Code Delayed Capture returned */
public String GetR_AuthCode_DC() 
{
return (String)Get_Value("R_AuthCode_DC");
}

/** R_AvsAddr AD_Reference_ID=213 */
public static int R_AVSADDR_AD_Reference_ID=213;
/** No Match = N */
public static String R_AVSADDR_NoMatch = "N";
/** Unavailable = X */
public static String R_AVSADDR_Unavailable = "X";
/** Match = Y */
public static String R_AVSADDR_Match = "Y";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsR_AvsAddrValid (String test)
{
return test == null || test.Equals("N") || test.Equals("X") || test.Equals("Y");
}
/** Set Address verified.
@param R_AvsAddr This address has been verified */
public void SetR_AvsAddr (String R_AvsAddr)
{
if (!IsR_AvsAddrValid(R_AvsAddr))
throw new ArgumentException ("R_AvsAddr Invalid value - " + R_AvsAddr + " - Reference_ID=213 - N - X - Y");
if (R_AvsAddr != null && R_AvsAddr.Length > 1)
{
log.Warning("Length > 1 - truncated");
R_AvsAddr = R_AvsAddr.Substring(0,1);
}
Set_ValueNoCheck ("R_AvsAddr", R_AvsAddr);
}
/** Get Address verified.
@return This address has been verified */
public String GetR_AvsAddr() 
{
return (String)Get_Value("R_AvsAddr");
}

/** R_AvsZip AD_Reference_ID=213 */
public static int R_AVSZIP_AD_Reference_ID=213;
/** No Match = N */
public static String R_AVSZIP_NoMatch = "N";
/** Unavailable = X */
public static String R_AVSZIP_Unavailable = "X";
/** Match = Y */
public static String R_AVSZIP_Match = "Y";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsR_AvsZipValid (String test)
{
return test == null || test.Equals("N") || test.Equals("X") || test.Equals("Y");
}
/** Set Zip verified.
@param R_AvsZip The Zip Code has been verified */
public void SetR_AvsZip (String R_AvsZip)
{
if (!IsR_AvsZipValid(R_AvsZip))
throw new ArgumentException ("R_AvsZip Invalid value - " + R_AvsZip + " - Reference_ID=213 - N - X - Y");
if (R_AvsZip != null && R_AvsZip.Length > 1)
{
log.Warning("Length > 1 - truncated");
R_AvsZip = R_AvsZip.Substring(0,1);
}
Set_ValueNoCheck ("R_AvsZip", R_AvsZip);
}
/** Get Zip verified.
@return The Zip Code has been verified */
public String GetR_AvsZip() 
{
return (String)Get_Value("R_AvsZip");
}
/** Set CVV Match.
@param R_CVV2Match Credit Card Verification Code Match */
public void SetR_CVV2Match (Boolean R_CVV2Match)
{
Set_ValueNoCheck ("R_CVV2Match", R_CVV2Match);
}
/** Get CVV Match.
@return Credit Card Verification Code Match */
public Boolean IsR_CVV2Match() 
{
Object oo = Get_Value("R_CVV2Match");
if (oo != null) 
{
 if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
 return "Y".Equals(oo);
}
return false;
}
/** Set Info.
@param R_Info Response info */
public void SetR_Info (String R_Info)
{
if (R_Info != null && R_Info.Length > 2000)
{
log.Warning("Length > 2000 - truncated");
R_Info = R_Info.Substring(0,2000);
}
Set_ValueNoCheck ("R_Info", R_Info);
}
/** Get Info.
@return Response info */
public String GetR_Info() 
{
return (String)Get_Value("R_Info");
}
/** Set Reference.
@param R_PnRef Payment reference */
public void SetR_PnRef (String R_PnRef)
{
if (R_PnRef != null && R_PnRef.Length > 20)
{
log.Warning("Length > 20 - truncated");
R_PnRef = R_PnRef.Substring(0,20);
}
Set_ValueNoCheck ("R_PnRef", R_PnRef);
}
/** Get Reference.
@return Payment reference */
public String GetR_PnRef() 
{
return (String)Get_Value("R_PnRef");
}
/** Set Reference (DC).
@param R_PnRef_DC Payment Reference Delayed Capture */
public void SetR_PnRef_DC (String R_PnRef_DC)
{
if (R_PnRef_DC != null && R_PnRef_DC.Length > 20)
{
log.Warning("Length > 20 - truncated");
R_PnRef_DC = R_PnRef_DC.Substring(0,20);
}
Set_ValueNoCheck ("R_PnRef_DC", R_PnRef_DC);
}
/** Get Reference (DC).
@return Payment Reference Delayed Capture */
public String GetR_PnRef_DC() 
{
return (String)Get_Value("R_PnRef_DC");
}
/** Set Response Message.
@param R_RespMsg Response message */
public void SetR_RespMsg (String R_RespMsg)
{
if (R_RespMsg != null && R_RespMsg.Length > 60)
{
log.Warning("Length > 60 - truncated");
R_RespMsg = R_RespMsg.Substring(0,60);
}
Set_ValueNoCheck ("R_RespMsg", R_RespMsg);
}
/** Get Response Message.
@return Response message */
public String GetR_RespMsg() 
{
return (String)Get_Value("R_RespMsg");
}
/** Set Result.
@param R_Result Result of transmission */
public void SetR_Result (String R_Result)
{
if (R_Result != null && R_Result.Length > 20)
{
log.Warning("Length > 20 - truncated");
R_Result = R_Result.Substring(0,20);
}
Set_ValueNoCheck ("R_Result", R_Result);
}
/** Get Result.
@return Result of transmission */
public String GetR_Result() 
{
return (String)Get_Value("R_Result");
}

/** Ref_Payment_ID AD_Reference_ID=343 */
public static int REF_PAYMENT_ID_AD_Reference_ID=343;
/** Set Referenced Payment.
@param Ref_Payment_ID Referenced Payment */
public void SetRef_Payment_ID (int Ref_Payment_ID)
{
if (Ref_Payment_ID <= 0) Set_ValueNoCheck ("Ref_Payment_ID", null);
else
Set_ValueNoCheck ("Ref_Payment_ID", Ref_Payment_ID);
}
/** Get Referenced Payment.
@return Referenced Payment */
public int GetRef_Payment_ID() 
{
Object ii = Get_Value("Ref_Payment_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Routing No.
@param RoutingNo Bank Routing Number */
public void SetRoutingNo (String RoutingNo)
{
if (RoutingNo != null && RoutingNo.Length > 20)
{
log.Warning("Length > 20 - truncated");
RoutingNo = RoutingNo.Substring(0,20);
}
Set_Value ("RoutingNo", RoutingNo);
}
/** Get Routing No.
@return Bank Routing Number */
public String GetRoutingNo() 
{
return (String)Get_Value("RoutingNo");
}
/** Set Swipe.
@param Swipe Track 1 and 2 of the Credit Card */
public void SetSwipe (String Swipe)
{
if (Swipe != null && Swipe.Length > 80)
{
log.Warning("Length > 80 - truncated");
Swipe = Swipe.Substring(0,80);
}
Set_ValueNoCheck ("Swipe", Swipe);
}
/** Get Swipe.
@return Track 1 and 2 of the Credit Card */
public String GetSwipe() 
{
return (String)Get_Value("Swipe");
}
/** Set Tax Amount.
@param TaxAmt Tax Amount for a document */
public void SetTaxAmt (Decimal? TaxAmt)
{
Set_Value ("TaxAmt", (Decimal?)TaxAmt);
}
/** Get Tax Amount.
@return Tax Amount for a document */
public Decimal GetTaxAmt() 
{
Object bd =Get_Value("TaxAmt");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}

/** TenderType AD_Reference_ID=214 */
public static int TENDERTYPE_AD_Reference_ID=214;
/** Direct Deposit = A */
public static String TENDERTYPE_DirectDeposit = "A";
/** Credit Card = C */
public static String TENDERTYPE_CreditCard = "C";
/** Direct Debit = D */
public static String TENDERTYPE_DirectDebit = "D";
/** Check = K */
public static String TENDERTYPE_Check = "K";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsTenderTypeValid (String test)
{
return test.Equals("A") || test.Equals("C") || test.Equals("D") || test.Equals("K");
}
/** Set Tender type.
@param TenderType Method of Payment */
public void SetTenderType (String TenderType)
{
if (TenderType == null) throw new ArgumentException ("TenderType is mandatory");
if (!IsTenderTypeValid(TenderType))
throw new ArgumentException ("TenderType Invalid value - " + TenderType + " - Reference_ID=214 - A - C - D - K");
if (TenderType.Length > 1)
{
log.Warning("Length > 1 - truncated");
TenderType = TenderType.Substring(0,1);
}
Set_Value ("TenderType", TenderType);
}
/** Get Tender type.
@return Method of Payment */
public String GetTenderType() 
{
return (String)Get_Value("TenderType");
}

/** TrxType AD_Reference_ID=215 */
public static int TRXTYPE_AD_Reference_ID=215;
/** Authorization = A */
public static String TRXTYPE_Authorization = "A";
/** Credit (Payment) = C */
public static String TRXTYPE_CreditPayment = "C";
/** Delayed Capture = D */
public static String TRXTYPE_DelayedCapture = "D";
/** Voice Authorization = F */
public static String TRXTYPE_VoiceAuthorization = "F";
/** Sales = S */
public static String TRXTYPE_Sales = "S";
/** Void = V */
public static String TRXTYPE_Void = "V";
/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsTrxTypeValid (String test)
{
return test.Equals("A") || test.Equals("C") || test.Equals("D") || test.Equals("F") || test.Equals("S") || test.Equals("V");
}
/** Set Transaction Type.
@param TrxType Type of credit card transaction */
public void SetTrxType (String TrxType)
{
if (TrxType == null) throw new ArgumentException ("TrxType is mandatory");
if (!IsTrxTypeValid(TrxType))
throw new ArgumentException ("TrxType Invalid value - " + TrxType + " - Reference_ID=215 - A - C - D - F - S - V");
if (TrxType.Length > 1)
{
log.Warning("Length > 1 - truncated");
TrxType = TrxType.Substring(0,1);
}
Set_Value ("TrxType", TrxType);
}
/** Get Transaction Type.
@return Type of credit card transaction */
public String GetTrxType() 
{
return (String)Get_Value("TrxType");
}

/** User1_ID AD_Reference_ID=134 */
public static int USER1_ID_AD_Reference_ID=134;
/** Set User List 1.
@param User1_ID User defined list element #1 */
public void SetUser1_ID (int User1_ID)
{
if (User1_ID <= 0) Set_Value ("User1_ID", null);
else
Set_Value ("User1_ID", User1_ID);
}
/** Get User List 1.
@return User defined list element #1 */
public int GetUser1_ID() 
{
Object ii = Get_Value("User1_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}

/** User2_ID AD_Reference_ID=137 */
public static int USER2_ID_AD_Reference_ID=137;
/** Set User List 2.
@param User2_ID User defined list element #2 */
public void SetUser2_ID (int User2_ID)
{
if (User2_ID <= 0) Set_Value ("User2_ID", null);
else
Set_Value ("User2_ID", User2_ID);
}
/** Get User List 2.
@return User defined list element #2 */
public int GetUser2_ID() 
{
Object ii = Get_Value("User2_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Voice authorization code.
@param VoiceAuthCode Voice Authorization Code from credit card company */
public void SetVoiceAuthCode (String VoiceAuthCode)
{
if (VoiceAuthCode != null && VoiceAuthCode.Length > 20)
{
log.Warning("Length > 20 - truncated");
VoiceAuthCode = VoiceAuthCode.Substring(0,20);
}
Set_Value ("VoiceAuthCode", VoiceAuthCode);
}
/** Get Voice authorization code.
@return Voice Authorization Code from credit card company */
public String GetVoiceAuthCode() 
{
return (String)Get_Value("VoiceAuthCode");
}
/** Set Write-off Amount.
@param WriteOffAmt Amount to write-off */
public void SetWriteOffAmt (Decimal? WriteOffAmt)
{
Set_Value ("WriteOffAmt", (Decimal?)WriteOffAmt);
}
/** Get Write-off Amount.
@return Amount to write-off */
public Decimal GetWriteOffAmt() 
{
Object bd =Get_Value("WriteOffAmt");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set IsOpeningPayment.
@param IsOpeningPayment Indicates Opening Payment */
public void SetIsOpeningPayment(Boolean IsOpeningPayment)
{
    Set_Value("IsOpeningPayment", IsOpeningPayment);
}
/** Get Opening Payment.
@return Indicates Opening Payment */
public Boolean IsOpeningPayment()
{
    Object oo = Get_Value("IsOpeningPayment");
    if (oo != null)
    {
        if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
        return "Y".Equals(oo);
    }
    return false;
}
/** Set Invoice Payment Schedule.
@param C_InvoicePaySchedule_ID Invoice Payment Schedule */
public void SetC_InvoicePaySchedule_ID(int C_InvoicePaySchedule_ID)
{
    if (C_InvoicePaySchedule_ID <= 0) Set_Value("C_InvoicePaySchedule_ID", null);
    else
        Set_Value("C_InvoicePaySchedule_ID", C_InvoicePaySchedule_ID);
}
/** Get Invoice Payment Schedule.
@return Invoice Payment Schedule */
public int GetC_InvoicePaySchedule_ID()
{
    Object ii = Get_Value("C_InvoicePaySchedule_ID");
    if (ii == null) return 0;
    return Convert.ToInt32(ii);
}
}

}
