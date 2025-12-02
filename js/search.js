window.addEventListener("load", function () {
    search();
})
const books = [
    { name: "BOUNTY", link: "bounty.html" },
    { name: "CABIN", link: "bounty.html" },
    { name: "BEHIND THE DARK", link: "dark.html" },
    { name: "HUNTER", link: "hunter.html" },
    { name: "JOURNY", link: "journy.html" },
    { name: "MANOR", link: "manor.html" },
    { name: "THE RED HOUSE", link: "redHouse.html" },
    { name: "RULER", link: "ruler.html" },
    { name: "SPACE", link: "sapce.html" },
    { name: "SILECNE", link: "silence.html" },
    { name: "SILECNE RED", link: "silenceRed.html" },
    { name: "THE SOLIDER", link: "solider.html" },
    { name: "TERRA", link: "terra.html" },
    { name: "TOP SECRET", link: "topSecret" },
    { name: "WARRIOR", link: "warrior.html" },
    { name: "FAITH", link: "faithBook.html" },
];
const input = document.getElementById("searchInput");
const results = document.getElementById("results");

function search() {
    input.addEventListener("input", function () {
    const query = this.value.toLowerCase();
    results.innerHTML = ""; // نفضي النتائج أولاً
    if (query === "") {
        document.querySelector(".resCon").classList.add("d-none");
        return
        };
    document.querySelector(".resCon").classList.remove("d-none");
    books.forEach(book => {
        if (book.name.toLowerCase().includes(query)) {
            const a = document.createElement("a");
            a.href = book.link;
            a.textContent = book.name;
            results.appendChild(a);
        }
    });
});
}
search()