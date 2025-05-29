# The Web Service Testing form

The Web Service Testing form is a form in Avatar that is used to test the Tingen web service. It has a number of controls/fields that you can attach ScriptLink events to.

## Usage

1. Open the "Web Service Testing" form
2. Select a client (e.g., "40 - Test, Report")
3. Select an episode

## Existing Script Link events

In general, the Web Service Testing form has the following ScriptLink events:

### UAT

| Event     | Script             | Parameter                |
| --------- | ------------------ | ------------------------ |
| Form Load | Tingen_development | Admin-Service-Update-All |
| Pre-File  | None               | None                     |
| Post-File | None               | None                     |

### LIVE

| Event     | Script             | Parameter                |
| --------- | ------------------ | ------------------------ |
| Form Load | None               | None                     |
| Pre-File  | None               | None                     |
| Post-File | None               | None                     |
  