# 💶 ATM Denomination Solver

A professional C# solution for calculating all possible payout combinations from an ATM using only three bill types: **10 EUR**, **50 EUR**, and **100 EUR**.

---

## 📜 Problem

The ATM must return all possible combinations of denominations to match exact payout amounts. Available bills:

- 🪙 10 EUR
- 🧾 50 EUR
- 💶 100 EUR

**Amounts to solve:**
`30, 50, 60, 80, 140, 230, 370, 610, 980`

---

## 🧠 Approach

A brute-force iteration through all combinations of 100s and 50s, checking if the remainder is divisible by 10:

1. Loop `h` from 0 to `amount / 100`
2. Loop `f` from 0 to `(amount - 100*h) / 50`
3. If remainder after subtracting `(100*h + 50*f)` is divisible by 10, it's valid
4. Add `(t, f, h)` to result list

---

## 🗂️ Project Structure

```text
atm-denomination-solver/
├── Program.cs                     # Entry point
├── Models/
│   └── Combination.cs             # Denomination data model
├── Services/
│   └── DenominationSolver.cs      # Core logic
├── Tests/
│   └── DenominationSolverTests.cs # Unit tests (xUnit)
└── README.md                      # Project documentation

```
---

## 🧪 Sample Output

For `100 EUR`:

10 x 10 EUR, 0 x 50 EUR, 0 x 100 EUR
5 x 10 EUR, 1 x 50 EUR, 0 x 100 EUR
0 x 10 EUR, 2 x 50 EUR, 0 x 100 EUR
0 x 10 EUR, 0 x 50 EUR, 1 x 100 EUR


---

## 🔧 How to Run

```bash
dotnet run


dotnet test
