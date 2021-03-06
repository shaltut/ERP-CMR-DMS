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
/** Generated Model for M_LotCtl
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_M_LotCtl : PO
{
public X_M_LotCtl (Context ctx, int M_LotCtl_ID, Trx trxName) : base (ctx, M_LotCtl_ID, trxName)
{
/** if (M_LotCtl_ID == 0)
{
SetCurrentNext (0);	// 100
SetIncrementNo (0);	// 1
SetM_LotCtl_ID (0);
SetName (null);
SetStartNo (0);	// 100
}
 */
}
public X_M_LotCtl (Ctx ctx, int M_LotCtl_ID, Trx trxName) : base (ctx, M_LotCtl_ID, trxName)
{
/** if (M_LotCtl_ID == 0)
{
SetCurrentNext (0);	// 100
SetIncrementNo (0);	// 1
SetM_LotCtl_ID (0);
SetName (null);
SetStartNo (0);	// 100
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_LotCtl (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_LotCtl (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_LotCtl (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_M_LotCtl()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514379898L;
/** Last Updated Timestamp 7/29/2010 1:07:43 PM */
public static long updatedMS = 1280389063109L;
/** AD_Table_ID=556 */
public static int Table_ID;
 // =556;

/** TableName=M_LotCtl */
public static String Table_Name="M_LotCtl";

protected static KeyNamePair model;
protected Decimal accessLevel = new Decimal(3);
/** AccessLevel
@return 3 - Client - Org 
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
protected override POInfo InitPO(Context ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Info
@return info
*/
public override String ToString()
{
StringBuilder sb = new StringBuilder ("X_M_LotCtl[").Append(Get_ID()).Append("]");
return sb.ToString();
}
/** Set Current Next.
@param CurrentNext The next number to be used */
public void SetCurrentNext (int CurrentNext)
{
Set_Value ("CurrentNext", CurrentNext);
}
/** Get Current Next.
@return The next number to be used */
public int GetCurrentNext() 
{
Object ii = Get_Value("CurrentNext");
if (ii == null) return 0;
return Convert.ToInt32(ii);
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
/** Set Increment.
@param IncrementNo The number to increment the last document number by */
public void SetIncrementNo (int IncrementNo)
{
Set_Value ("IncrementNo", IncrementNo);
}
/** Get Increment.
@return The number to increment the last document number by */
public int GetIncrementNo() 
{
Object ii = Get_Value("IncrementNo");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Lot Control.
@param M_LotCtl_ID Product Lot Control */
public void SetM_LotCtl_ID (int M_LotCtl_ID)
{
if (M_LotCtl_ID < 1) throw new ArgumentException ("M_LotCtl_ID is mandatory.");
Set_ValueNoCheck ("M_LotCtl_ID", M_LotCtl_ID);
}
/** Get Lot Control.
@return Product Lot Control */
public int GetM_LotCtl_ID() 
{
Object ii = Get_Value("M_LotCtl_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name)
{
if (Name == null) throw new ArgumentException ("Name is mandatory.");
if (Name.Length > 60)
{
log.Warning("Length > 60 - truncated");
Name = Name.Substring(0,60);
}
Set_Value ("Name", Name);
}
/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() 
{
return (String)Get_Value("Name");
}
/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() 
{
return new KeyNamePair(Get_ID(), GetName());
}
/** Set Prefix.
@param Prefix Prefix before the sequence number */
public void SetPrefix (String Prefix)
{
if (Prefix != null && Prefix.Length > 10)
{
log.Warning("Length > 10 - truncated");
Prefix = Prefix.Substring(0,10);
}
Set_Value ("Prefix", Prefix);
}
/** Get Prefix.
@return Prefix before the sequence number */
public String GetPrefix() 
{
return (String)Get_Value("Prefix");
}
/** Set Start No.
@param StartNo Starting number/position */
public void SetStartNo (int StartNo)
{
Set_Value ("StartNo", StartNo);
}
/** Get Start No.
@return Starting number/position */
public int GetStartNo() 
{
Object ii = Get_Value("StartNo");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Suffix.
@param Suffix Suffix after the number */
public void SetSuffix (String Suffix)
{
if (Suffix != null && Suffix.Length > 10)
{
log.Warning("Length > 10 - truncated");
Suffix = Suffix.Substring(0,10);
}
Set_Value ("Suffix", Suffix);
}
/** Get Suffix.
@return Suffix after the number */
public String GetSuffix() 
{
return (String)Get_Value("Suffix");
}
}

}
