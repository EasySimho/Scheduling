# Applicazione di Scheduling

Questo repository contiene una semplice applicazione di scheduling implementata in C# utilizzando Windows Forms. L'applicazione consente agli utenti di simulare vari algoritmi di scheduling dei lavori e analizzare le relative metriche di prestazione.

---

## Caratteristiche

- **Elenco dei Lavori**: Gli utenti possono aggiungere lavori specificando il loro nome, estensione e tempo di esecuzione.
- **Calcolo delle Metriche**: Calcola metriche come il tempo medio di completamento e il tempo medio di attesa per i lavori schedulati.
- **Algoritmi di Scheduling**: Supporta diversi algoritmi di scheduling tra cui:
  - First Come First Served (FCFS)
  - Shortest Job First (SJF)
  - Round Robin (RR)
  - Round Robin Limitato (LRR)
- **Interfaccia Utente**: Fornisce un'interfaccia utente intuitiva per l'interazione e la visualizzazione del processo di scheduling.

---

## Come Utilizzare

1. **Aggiunta dei Lavori**:
   - Inserire i dettagli del lavoro nei campi forniti (Nome, Estensione, Tempo).
   - Fare clic sul pulsante "Aggiungi Lavoro" per aggiungere il lavoro all'elenco.

2. **Selezionare l'Algoritmo di Scheduling**:
   - Scegliere un algoritmo di scheduling dal menu a discesa.

3. **Avviare l'Esecuzione**:
   - Fare clic sul pulsante "Avvia" per avviare il processo di scheduling.

4. **Visualizzare le Metriche**:
   - Dopo il completamento dello scheduling, fare clic sul pulsante "Mostra Metriche" per visualizzare le metriche di prestazione.

---

## Algoritmi di Scheduling

1. **First Come First Served (FCFS)**:
   - I lavori vengono eseguiti nell'ordine in cui arrivano.

2. **Shortest Job First (SJF)**:
   - I lavori con il tempo di esecuzione più breve vengono eseguiti per primi.

3. **Round Robin (RR)**:
   - I lavori vengono eseguiti ciclicamente con una slice di tempo fissa.

4. **Round Robin Limitato (LRR)**:
   - Simile a RR, ma ogni lavoro ha un numero limitato di slice di tempo.

---

## Note

- Assicurarsi che siano stati inseriti parametri validi per il lavoro prima di aggiungerlo.
- Selezionare un algoritmo di scheduling prima di avviare il processo.
- Per Round Robin Limitato, specificare il numero massimo di slice di tempo per lavoro.

---

## Collaboratori

- Simho - (https://github.com/EasySimho/)

---
