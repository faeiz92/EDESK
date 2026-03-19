let allData = [];

// Load JSON
fetch('/data/customers.json')
    .then(res => res.json())
    .then(data => {
        allData = data;
        renderTable(data);
    });

// Render Table
function renderTable(data) {
    let tbody = document.querySelector("#customerTable tbody");
    tbody.innerHTML = "";

    data.forEach((c, index) => {
        tbody.innerHTML += `
            <tr>
                <td>${index + 1}</td>
                <td>${c.name}</td>
                <td>${c.address}</td>
                <td>${c.city}</td>
                <td>${c.pinCode}</td>
                <td>${c.country}</td>
                <td>

                    <!-- VIEW -->
                    <button class="btn btn-sm btn-info me-1"
                        onclick='viewData(${JSON.stringify(c)})'>
                        <i class="bi bi-eye"></i>
                    </button>

                    <!-- EDIT -->
                    <button class="btn btn-sm btn-warning me-1"
                        onclick='editData(${JSON.stringify(c)})'>
                        <i class="bi bi-pencil"></i>
                    </button>

                    <!-- DELETE -->
                    <button class="btn btn-sm btn-danger"
                        onclick='deleteData(${JSON.stringify(c)})'>
                        <i class="bi bi-trash"></i>
                    </button>

                </td>
            </tr>
        `;
    });
}

// Filter by Tree
function filterCity(city) {
    if (city === "All") {
        renderTable(allData);
    } else {
        let filtered = allData.filter(x => x.city === city);
        renderTable(filtered);
    }
}

// View Button
function viewData(data) {
    console.log(data);
    alert("Selected: " + JSON.stringify(data, null, 2));
}

function editData(data) {
    console.log("Edit:", data);
    alert("Edit:\n" + JSON.stringify(data, null, 2));
}

function deleteData(data) {
    console.log("Delete:", data);

    if (confirm("Are you sure to delete " + data.name + "?")) {
        alert("Deleted: " + data.name);
    }
}

// Tab Switch
function showTab(tab) {

    // default fallback
    if (!tab || (tab !== "home" && tab !== "profile")) {
        tab = "home";
    }

    document.getElementById("homeTab").style.display =
        tab === "home" ? "block" : "none";

    document.getElementById("profileTab").style.display =
        tab === "profile" ? "block" : "none";
}

// Login Submit
function submitLogin(e) {
    e.preventDefault();

    let userId = document.getElementById("userId").value;
    let password = document.getElementById("password").value;

    console.log({ userId, password });
    alert(`Login:\nUserID: ${userId}\nPassword: ${password}`);
}

function setActive(el) {
    // remove all active
    document.querySelectorAll('.tree-item, .tree-sub, .tree-header')
        .forEach(x => x.classList.remove('active-node'));

    // set current
    el.classList.add('active-node');
}