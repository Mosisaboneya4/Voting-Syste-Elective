# Form2 Module

**Contributed by:** Aisha2mohammed (Student 2)  
**Email:** hayunadus111@gmail.com

## Overview
Form2 is the user registration module of the Voting System. It allows
new users to create an account that is stored in the `login_db` MySQL
database via the `users` table.

## Files in this module
- `Form2.vb` – Form logic (handles user input, validation, DB insert)
- `Form2.Designer.vb` – Auto-generated designer file (control layout)
- `Form2.resx` – Form resources (localized strings, icons)

## How it works
1. User fills in **Full Name**, **Username**, **Password**, and **Role**.
2. On submit, the form inserts a new row into the `users` table.
3. Password handling and DB connection are managed by
   `PasswordHelper` and `DatabaseHelper` respectively.

> See the project root `README.md` for setup and build instructions.
