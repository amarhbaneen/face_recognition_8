from tkinter import *
import sqlite3
#================
root = Tk()
root.title("FRZ APP")
width = 400
height = 280
screen_width = root.winfo_screenwidth()
screen_height = root.winfo_screenheight()
x = (screen_width/2) - (width/2)
y = (screen_height/2) - (height/2)
root.geometry("%dx%d+%d+%d" % (width, height, x, y))
root.resizable(0, 0)

# ==============================VARIABLES======================================
USERNAME = StringVar()
PASSWORD = StringVar()
firstname =StringVar()
lastname = StringVar()

# ==============================FRAMES=========================================
Top = Frame(root, bd=2, relief=RIDGE)
Top.pack(side=TOP, fill=X)
Form = Frame(root, height=200)
Form.pack(side=TOP, pady=20)

# ==============================LABELS=========================================
lbl_title = Label(Top, text="FACE_REC APP ", font=('arial', 15))
lbl_title.pack(fill=X)
lbl_username = Label(Form, text="Username:", font=('arial', 14), bd=15)
lbl_username.grid(row=0, sticky="e")
lbl_password = Label(Form, text="Password:", font=('arial', 14), bd=15)
lbl_password.grid(row=1, sticky="e")
lbl_text = Label(Form)
lbl_text.grid(row=2, columnspan=2)

# ==============================ENTRY WIDGETS==================================
username = Entry(Form, textvariable=USERNAME, font=(14))
username.grid(row=0, column=1)
password = Entry(Form, textvariable=PASSWORD, show="*", font=(14))
password.grid(row=1, column=1)
#=========================MAIN FUNCTION=================#
def Login(event=None):
    Database()
    if USERNAME.get() == "" or PASSWORD.get() == "":
        lbl_text.config(text="Please complete the required field!", fg="red")
    else:
        cursor.execute("SELECT * FROM `member` WHERE `username` = ? AND `password` = ?",
                       (USERNAME.get(), PASSWORD.get()))
        if cursor.fetchone() is not None:
            HomeWindow()
            USERNAME.set("")
            PASSWORD.set("")
            lbl_text.config(text="")
        else:
            lbl_text.config(text="Invalid username or password", fg="red")
            USERNAME.set("")
            PASSWORD.set("")
    cursor.close()
    conn.close()
# ==============================BUTTON WIDGETS=================================
btn_login = Button(Form, text="Login", width=45, command=Login)
btn_login.grid(pady=25, row=3, columnspan=2)
btn_login.bind('<Return>', Login)


# ==============================METHODS========================================
def Database():
    global conn, cursor
    conn = sqlite3.connect("mydb.db")
    cursor = conn.cursor()
    cursor.execute("CREATE TABLE IF NOT EXISTS `people` (firstname TEXT, lastname TEXT,photo JPEG)")
    cursor.execute("CREATE TABLE IF NOT EXISTS `patient` (ptn_id INTEGER NOT NULL PRIMARY KEY  AUTOINCREMENT, username TEXT, password TEXT,firstname TEXT, lastname TEXT,photo JPEG)")
    cursor.execute("CREATE TABLE IF NOT EXISTS `partner` (ptr_id INTEGER NOT NULL PRIMARY KEY  AUTOINCREMENT, username TEXT, password TEXTfirstname TEXT, lastname TEXT,photo JPEG)")
    cursor.execute("SELECT * FROM `member` WHERE `username` = 'admin' AND `password` = 'admin'")
    if cursor.fetchone() is None:
        cursor.execute("INSERT INTO `member` (username, password) VALUES('admin', 'admin')")
        conn.commit()
#=================insert_human=====================#
def insert_person():
      cursor.execute("INSERT INTO `people` (firstname,lastname) VALUES(?,?)", (firstname,lastname))
      conn.commit()






#===========================================#
def HomeWindow():
    global Home
    root.withdraw()
    Home = Toplevel()
    Home.title("FACE_REC APP")
    width = 600
    height = 500
    screen_width = root.winfo_screenwidth()
    screen_height = root.winfo_screenheight()
    x = (screen_width / 2) - (width / 2)
    y = (screen_height / 2) - (height / 2)
    root.resizable(0, 0)
    Home.geometry("%dx%d+%d+%d" % (width, height, x, y))
    lbl_home = Label(Home, text="Successfully Login!", font=('times new roman', 20)).pack()
   
    btn_back = Button(Home, text='Back', command=Back).pack(pady=20, fill=X)
    lbl_button1= Button(Home,text="insertperson", COMMAND=insert_person()).pack()


def Back():
    Home.destroy()
    root.deiconify()
    # ==============================INITIALIATION==================================


if __name__ == '__main__':
    root.mainloop()