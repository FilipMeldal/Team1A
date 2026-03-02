# UC1 SOC – Opret mål

## SOC-1: VisDashboard()
- **Operation:** `VisDashboard()`
- **Kilde:** Ledelsen
- **Formål:** Vise samlet oversigt over eksisterende bæredygtighedsdata.
- **Referencer:** UC1 Hovedscenarie trin 1

### Forudsætninger
- Ledelsen er logget ind og har adgang til dashboard.

### Efterbetingelser
- Systemet viser en oversigt over relevante bæredygtighedsdata.
- Ingen forretningsdata ændres.

---

## SOC-2: VælgSætMål()
- **Operation:** `VælgSætMål()`
- **Kilde:** Ledelsen
- **Formål:** Åbne funktion til oprettelse af mål.
- **Referencer:** UC1 Hovedscenarie trin 2

### Forudsætninger
- Dashboard er vist for Ledelsen.

### Efterbetingelser
- Formular/UI til målopsætning er vist.
- Ingen mål er gemt endnu.

---

## SOC-3: IndtastMål(datatype, målværdi, måldato)
- **Operation:** `IndtastMål(datatype, målværdi, måldato)`
- **Kilde:** Ledelsen
- **Formål:** Registrere et konkret mål for valgt bæredygtighedsdata inden en specifik dato.
- **Referencer:** UC1 Hovedscenarie trin 3–4, Succesgaranti

### Input (parametre)
- `datatype`: hvilken bæredygtighedsdata målet vedrører (fx CO2, energi, affald)
- `målværdi`: den ønskede værdi/målsætning
- `måldato`: dato hvor målet skal være opnået

### Forudsætninger
- Formular for målopsætning er vist.
- `datatype` findes blandt systemets bæredygtighedsdata.
- `målværdi` er udfyldt med en gyldig numerisk værdi.
- `måldato` er en gyldig dato.

### Efterbetingelser
- Målet er oprettet i systemet for den valgte `datatype`.
- Opdateret oversigt vises med:
  - det nye mål
  - nuværende data
  - beregnet fremdrift mod målet

### Valideringsregler (foreslået)
- `målværdi` skal være > 0.
- `måldato` må ikke være tom.
- `datatype` skal være valgt fra gyldig liste.

### Fejltilfælde (foreslået)
- Hvis `datatype` mangler/er ugyldig: systemet viser fejl og beder om gyldigt valg.
- Hvis `målværdi` er ugyldig: systemet viser fejl og beder om gyldig værdi.
- Hvis `måldato` er ugyldig: systemet viser fejl og beder om gyldig dato.
- Ved fejl gemmes intet mål.
