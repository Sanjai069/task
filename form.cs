body {
  font-family: "Lato", sans-serif;
}

.header-nav {
  height: 100%;
  width: 200px;
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  background-color: #272323;
  overflow-x: hidden;
  padding-top: 60px;
}
.header-nav a {
  padding: 8px 8px 8px 32px;
  text-decoration: none;
  font-size: 20px;
  color: #f3e9e9;
  display: block;
}
.header-nav a img {
  width: 20px;
  height: 20px;
  margin-right: 10px;
}
.header-nav a:hover {
  color: #1532d6;
}

.h1 {
  font-size: 20px;
  color: #f3e9e9;
}
.buttons-top {
  display: flex;
  flex-direction: row;
  justify-content: flex-end;
  padding: 10px;
}

.button-publish,
.button-preview {
  padding: 10px 20px;
  border: none;
  color: white;
  cursor: pointer;
  transition: background-color 0.3s;
}

.button-publish {
  background-color: #4caf50;
  margin: 5px;
}

.button-publish:hover {
  background-color: #45a049;
}

.button-preview {
  background-color: #008cba;
  margin: 5px;
}

.button-preview:hover {
  background-color: #007a8a;
}

#form-builder {
  display: flex;
}

#toolbox {
  width: 150px;
  min-height: 300px;
  padding: 20px;
  border: 5px solid #ccc;
}

#toolbox .draggable {
  padding: 10px;
  margin-bottom: 10px;
  background-color: #f9f9f9;
  border: 1px solid #ccc;
  cursor: move;
}
#form-preview {
  padding: 250px;
  border: 1px solid #0945ec;
  display: flex;
  flex-direction: row;
  align-items: flex-start;
  width: 610px;
  margin-left: calc(160px + 50px);
}
.buttons-bottom {
  display: flex;
  flex-direction: row;
  justify-content: flex-end;
  padding: 10px;
}

.button-clear,
.button-save {
  padding: 10px 20px;
  border: none;
  color: white;
  cursor: pointer;
  transition: background-color 0.3s;
}

.button-clear {
  background-color: #4caf50;
  margin: 5px;
}

.button-clear:hover {
  background-color: #45a049;
}

.button-save {
  background-color: #008cba;
  margin: 5px;
}

.button-save:hover {
  background-color: #007a8a;
}
.layout {
  display: flex;
  flex-direction: row;
}

.layout-section {
  flex: 1;
  width: 400px;
  height: 200px;
  padding: 10px;
  border: 1px solid #da00cf;
  margin: 5px;
}

@media screen and (max-height: 450px) {
  .sidenav {
    padding-top: 15px;
    width: 250px;
  }
  .sidenav a {
    font-size: 18px;
  }
}