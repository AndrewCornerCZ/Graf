<strong>Definice grafu</strong>

Graf je struktura složená z vrcholů a spojení mezi nima.

<li>Neorientovaný graf – hrany nemají směr (např. spojení A–B je stejné jako B–A).

<li>Orientovaný graf (digraf) – hrany mají směr (např. A → B není totéž co B → A).

<li>Ohodnocený graf (vážený) – každá hrana má přidělenou hodnotu třeba délka.
<br>

<strong>Kostra grafu</strong>

Kostra grafu je podgraf neorientovaného souvislého grafu, který:

<li>Obsahuje všechny vrcholy původního grafu

<li>Neobsahuje žádné cykly

<li>Je souvislý (každý vrchol je dosažitelný z libovolného jiného)

<strong>Matice sousednosti vs. seznam sousedů</strong>

Matice sousednosti:
<li>Vhodné pro husté grafy</li>
<li>Jde o čtvercovou matici 𝑛 × 𝑛, kde 𝑛 je počet vrcholů.</li>
<br>
Seznam sousedů:
<li>Každý vrchol má seznam vrcholů, ke kterým vede hrana</li>
<li>Může být reprezentován jako pole seznamů nebo slovník (např. A → [B, C])</li>
<br>
<strong>Reálné příklady využití grafů</strong>
<li>Navigace a mapy (vrcholy = křižovatky, hrany = silnice, váhy = vzdálenosti/časy)

<li>Počítačové sítě (uzly = počítače, hrany = kabely/spojení)

<li>Plánování projektů (uzly = úkoly, hrany = závislosti)

<li>Sociální sítě (uzly = lidé, hrany = vztahy/mezi nimi)</li>
<br>
<strong>Problém hledání nejkratší cesty</strong><br>
<strong>Co znamená „nejkratší cesta“</strong><br>
Cesta mezi dvěma vrcholy, která má nejmenší možnou součet ohodnocení hran.

Používá se v navigaci, síťových přenosech, logistice apod.

<strong>Negativní hrany a jejich vliv</strong>
Negativní hrana je hrana v ohodnoceném grafu, jejíž váha (hodnota) je záporná — například −5. V některých reálných problémech může znamenat zisk, slevu nebo obrácený tok.

Algoritmy:

Dijkstra: nefunguje správně s negativními hranami (předpokládá kladné váhy).

Bellman-Ford: funguje i s negativními hranami a umí detekovat negativní cykly.

Negativní cyklus: pokud existuje smyčka se zápornou celkovou hodnotou, neexistuje konečná nejkratší cesta (lze ji neustále zkracovat).
