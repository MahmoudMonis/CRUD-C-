const form = document.getElementById('addForm');
const table = document.getElementById('studentsTable');

form.addEventListener('submit', function(e) {
  e.preventDefault();

  const idInput = document.getElementById('addId');
  const nameInput = document.getElementById('addName');
  const marksInput = document.getElementById('addMarks');

  const id = parseInt(idInput.value);
  const name = nameInput.value;
  const marks = parseInt(marksInput.value);

  const row = table.insertRow();
  row.innerHTML = `
    <td>${id}</td>
    <td>${name}</td>
    <td>${marks}</td>
  `;

  idInput.value = '';
  nameInput.value = '';
  marksInput.value = '';
});