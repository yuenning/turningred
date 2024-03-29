import { IPortkeyProvider, MethodsBase} from "@portkey/provider-types";
import { useEffect, useState } from "react";
import './Transaction.css';
import {Link} from "react-router-dom";
import { useAuth } from "../contexts/AuthContext"; 

function Transaction({ provider }: { provider: IPortkeyProvider | null }) {
    const [senderID, setSenderID] = useState("");
    const [itemID, setItemID] = useState("");
    const [rfidTag, setRfidTag] = useState("");
    const [quantity, setQuantity] = useState("");
    const [transactionAmount, setTransactionAmount] = useState("");
    const [remarks, setRemarks] = useState("");

    // form validation
    const [formErrors, setFormErrors] = useState([]);

    const validateForm () => {
        const errors = [];

        if (!senderID.trim()) {
            errors.push("Sender ID field needs to be filled in.");
        }
        if (!itemID.trim()) {
            errors.push("Item ID field needs to be filled in.");
        }
        if (!rfidTag.trim()) {
            errors.push("RFID Tag field needs to be filled in.");
        }
        if (!quantity.trim()) {
            errors.push("Quantity field needs to be filled in.");
        }
        if (!transactionAmount.trim()) {
            errors.push("Transaction Amount field needs to be filled in.");
        }

        return errors;
    }

    const sendTransaction = async () => {
        setFormErrors([]);
        const errors = validateForm();

        if (errors && errors.length > 0) {
            setFormErrors(errors);
            return;
        }

        if (errors && errors.length > 0) {
            setFormErrors(errors);
            return;
        }

        try {
            const accounts = await provider?.request({
                method: MethodsBase.ACCOUNTS,
            });
            if (!accounts) throw new Error("No accounts");

            const account = accounts?.tDVW?.[0];
            if (!account) throw new Error("No account");

            const receipt = await provider?.request({
                method: MethodsBase.SEND_TRANSACTION,
                payload: {
                    rpcUrl: string,
                    chainId: ChainId,
                    contractAddress: useAuth(),
                    method: string, //smart contract method
                    params?: {
                        senderID: senderID,
                        itemID: itemID,
                        rfidTag: rfidTag,
                        quantity: quantity,
                        transactionAmount: transactionAmount,
                        remarks: remarks,
                    }
                }});

            if(!accounts) throw new Error('transaction failed!');
            console.log('transaction success! transaction id:', accounts);

            alert(
                `Successfully recorded!\n Transaction ID: ${accounts}\nTotal Amount: $${transactionAmount}`
              );
            setFormErrors([]);
            } catch (e) {
            // An error will be thrown if the user denies the permission request, or other issues.
            console.log('transaction failed!', e);
            }

        if (!provider) return null;

    }

    return (
        <div className="form">
            {formErrors && formErrors.length > 0 && (
        <div style={{ color: "red" }}>
          {formErrors.map((error, index) => (
            <p key={index}>{error}</p>
          ))}
        </div>
      )}
            <div className="field-group">
                <h2 className="field-label">Sender ID</h2>
                <input type="text" id="sender-id" placeholder='' onChange={(e) => setSenderID(e.target.value)} value={senderID}/>
            </div>
            <div className="field-group">
                <h2 className="field-label">Item ID</h2>
                <input type="text" id="item-id" placeholder=''/>
            </div>
            <div className="field-group">
                <h2 className="field-label">RFID Tag No.</h2>
                <input type="text" id="rfid" placeholder=''/>
            </div>
            <div className="field-group">
                <h2 className="field-label">Quantity</h2>
                <input type="number" id="quantity" min="0" placeholder=''/>
            </div>
            <div className="field-group">
                <h2 className="field-label">Transaction Amount</h2>
                <input type="number" id="transaction-amount" min="0" placeholder=''/>
            </div>
            <div className="field-group">
                <h2 className="field-label">Remarks</h2>
                <input type="text" id="remarks" placeholder=''/>
            </div>
            <Link to={'/'} className="text-center" style={{justifyContent: "center", alignItems:"center"}}>
                <button onClick={sendTransaction} style={{backgroundColor: "#f1b6ac",border: "none",fontSize:18, lineHeight:1.5, display: "inline-block"}}>
                    Send Transaction
                </button>
            </Link>
        </div>
    );
}

export default Transaction;