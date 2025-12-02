.font1 {
  font-family: "Roboto Condensed", sans-serif;
}

.font2 {
  font-family: "Pinyon Script", cursive;
}

.font3 {
  font-family: "Italianno";
}

.color1 {
  color: #e4c590;
}

.title h2 {
  margin-bottom: 0;
}
.title img {
  width: 120px;
}
.title .titleHead {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  justify-content: flex-start;
}
.title .titleHead img {
  width: 75px;
  margin-bottom: 6px;
}

.btnb {
  background-color: transparent;
  border: 2px solid #e4c590;
  color: white;
  padding: 10px 25px;
  border-radius: 5px;
  font-family: "Roboto Condensed", sans-serif;
  position: relative;
  overflow: hidden;
  margin-right: 1rem;
}
.btnb p {
  position: relative;
}
.btnb::before {
  position: absolute;
  top: 50%;
  right: initial;
  bottom: initial;
  left: 50%;
  content: "";
  display: block;
  width: 50px;
  height: 50px;
  background-color: rgba(228, 197, 144, 0.6117647059);
  border: 2px solid transparent;
  opacity: 0;
  transform: translate(-50%, -50%);
  border-radius: 100%;
  transition: all 0.7s;
}
.btnb:hover::before {
  border-radius: 0;
  width: 110% !important;
  height: 110% !important;
  opacity: 1;
}

a {
  text-decoration: none;
}

.navLinks {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
@media (max-width: 1300px) {
  .navLinks {
    display: none;
  }
}
@media (min-width: 769px) and (max-width: 1300px) {
  .navLinks {
    display: initial;
  }
}
.navLinks ul {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  padding: 0;
  margin: 0;
  list-style: none;
}
.navLinks ul li {
  position: relative;
}
.navLinks ul li.active::before, .navLinks ul li.active::after {
  content: "";
  display: block;
  width: 20px;
  height: 10px;
  background-color: transparent;
  border: 2px solid #e4c590;
  opacity: 1;
  position: absolute;
  border-width: 3px;
}
.navLinks ul li.active::before {
  top: 0;
  left: 0;
  border-right: 0;
  border-bottom: 0;
}
.navLinks ul li.active::after {
  border-top: 0;
  border-left: 0;
  right: 0;
  bottom: 0;
}
.navLinks ul li.active a p {
  color: #e4c590;
}
.navLinks ul li:not(:last-child) {
  margin-right: 20px;
}
.navLinks ul li {
  padding: 10px;
}
.navLinks ul li a {
  color: white;
}
.navLinks ul li a p {
  font-size: 20px;
  font-weight: 700;
  transition-duration: 1s !important;
}

.navLinks2 {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
@media (max-width: 1300px) {
  .navLinks2 {
    display: none;
  }
}
@media (min-width: 769px) and (max-width: 1300px) {
  .navLinks2 {
    display: initial;
  }
}
.navLinks2 ul {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding: 0;
  margin: 0;
  list-style: none;
}
.navLinks2 ul li {
  position: relative;
}
.navLinks2 ul li.active::before, .navLinks2 ul li.active::after {
  content: "";
  display: block;
  width: 20px;
  height: 10px;
  background-color: transparent;
  border: 2px solid #e4c590;
  opacity: 1;
  position: absolute;
  border-width: 3px;
}
.navLinks2 ul li.active::before {
  top: 0;
  left: 0;
  border-right: 0;
  border-bottom: 0;
}
.navLinks2 ul li.active::after {
  border-top: 0;
  border-left: 0;
  right: 0;
  bottom: 0;
}
.navLinks2 ul li.active a p {
  color: #e4c590;
}
.navLinks2 ul li {
  padding: 10px;
}
.navLinks2 ul li a {
  color: white;
}
.navLinks2 ul li a p {
  font-size: 20px;
  font-weight: 700;
  transition-duration: 1s !important;
}

.navLinks3 {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
@media (max-width: 1300px) {
  .navLinks3 {
    display: none;
  }
}
@media (min-width: 769px) and (max-width: 1300px) {
  .navLinks3 {
    display: initial;
  }
}
.navLinks3 ul {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding: 0;
  margin: 0;
  list-style: none;
}
.navLinks3 ul li {
  position: relative;
}
.navLinks3 ul li.active::before, .navLinks3 ul li.active::after {
  content: "";
  display: block;
  width: 20px;
  height: 10px;
  background-color: transparent;
  border: 2px solid #e4c590;
  opacity: 1;
  position: absolute;
  border-width: 3px;
}
.navLinks3 ul li.active::before {
  top: 0;
  left: 0;
  border-right: 0;
  border-bottom: 0;
}
.navLinks3 ul li.active::after {
  border-top: 0;
  border-left: 0;
  right: 0;
  bottom: 0;
}
.navLinks3 ul li.active a p {
  color: #e4c590;
}
.navLinks3 ul li {
  padding: 10px;
}
.navLinks3 ul li a {
  color: white;
}
.navLinks3 ul li a p {
  font-size: 20px;
  font-weight: 700;
  transition-duration: 1s !important;
}

.spre {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
.spre img {
  width: 120px;
}

html {
  scroll-behavior: auto !important;
}

body {
  scroll-behavior: auto !important;
}

* {
  scroll-behavior: auto !important;
}

@keyframes animiTranslate {
  0% {
    transform: translateY(-10px);
  }
  100% {
    transform: translateY(10px);
  }
}
@keyframes animiopacity {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
@keyframes animationRotate {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
@keyframes Swap {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
#Home.active .col1, #Home.active .col2 {
  transform: translateY(0);
  opacity: 1;
}
#Home {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  position: relative;
  background-image: url("../imgs/ChatGPT Image Oct 13, 2025, 12_25_21 AM.png");
  background-position: center;
  background-size: contain;
  overflow: hidden;
}
#Home::before {
  content: "";
  display: block;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.4);
  border: 2px solid transparent;
  opacity: 1;
  position: absolute;
  top: 0;
  right: initial;
  bottom: initial;
  left: 0;
  backdrop-filter: blur(5px);
  background: rgba(0, 0, 0, 0.363);
}
#Home .title .titleHead h2 {
  margin-top: 10px;
  font-size: 40px;
}
@media (max-width: 1300px) {
  #Home .title .titleHead h2 {
    font-size: 30px;
  }
}
#Home .col1 {
  transform: translateY(30px);
  opacity: 0;
  transition: all 0.8s;
}
#Home .col2 {
  transform: translateY(30px);
  opacity: 0;
  transition: all 0.8s;
}
@media (max-width: 1300px) {
  #Home .col2 {
    display: none;
  }
}
@media (min-width: 769px) and (max-width: 1300px) {
  #Home .col2 {
    display: initial;
  }
}
#Home .col2 .box {
  align-items: center;
  position: relative;
}
#Home .col2 .box .shapes {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  justify-content: space-between;
}
#Home .col2 .box .shapes img {
  transform: translateY(-50px);
  width: 50px;
}
@media (max-width: 1300px) {
  #Home .col2 .box .shapes img {
    width: 30px;
  }
}
#Home .col2 .box .shapes img {
  animation: animiopacity 1s infinite alternate ease-in-out;
}
#Home .col2 .box .shapes img.shape1 {
  transform: translate(-120px, 150px);
  animation-delay: 0s;
}
@media (min-width: 769px) and (max-width: 1300px) {
  #Home .col2 .box .shapes img.shape1 {
    transform: translate(-100px, 150px);
  }
}
#Home .col2 .box .shapes img.shape2 {
  transform: translateY(-30px);
  animation-delay: 0.3s;
}
#Home .col2 .box .shapes img.shape3 {
  transform: translate(120px, 150px);
}
@media (min-width: 769px) and (max-width: 1300px) {
  #Home .col2 .box .shapes img.shape3 {
    transform: translate(100px, 150px);
  }
}
#Home .col2 .box .shapes img.shape3 {
  animation-delay: 0.6s;
}
#Home .col2 .box img.mainImg {
  width: 250px;
}
@media (min-width: 769px) and (max-width: 1300px) {
  #Home .col2 .box img.mainImg {
    width: 200px;
  }
}
#Home .col2 .box img.mainImg {
  animation: animiTranslate 2s infinite alternate linear;
}
#Home .box {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-items: flex-start;
}
#Home .box .textCon {
  color: white;
}
#Home .box .textCon p {
  color: rgb(199, 199, 199);
}
@media (min-width: 769px) and (max-width: 1300px) {
  #Home .box .textCon p {
    font-size: 15px;
  }
}
#Home .members {
  position: absolute;
  top: initial;
  right: 0px;
  bottom: 20px;
  left: initial;
  cursor: pointer;
  border: 2px solid #e4c590;
  border-radius: 10px 0px 0px 10px;
  border-right: 0px;
  box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
  transform: translateX(190px);
  backdrop-filter: blur(5px);
  background: rgba(0, 0, 0, 0.603);
  transition: all 0.6s;
}
@media (max-width: 1300px) {
  #Home .members {
    transform: translateX(147px);
  }
}
@media (min-width: 371px) and (max-width: 1300px) {
  #Home .members {
    transform: translateX(155px);
  }
}
@media (min-width: 577px) and (max-width: 1300px) {
  #Home .members {
    transform: translateX(165px);
  }
}
@media (min-width: 769px) and (max-width: 1300px) {
  #Home .members {
    transform: translateX(175px);
  }
}
#Home .members:hover {
  transform: translateX(0);
}
#Home .members .box {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  padding: 5px 10px;
}
#Home .members .box img {
  width: 50px;
  margin-bottom: 10px;
}
#Home .members .box h2 {
  margin: 0;
  color: white;
}
#Home .butns {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
#Home .butns button {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
@media (max-width: 1300px) {
  #Home .butns button {
    padding: 10px 18px;
  }
}
#Home .butns button p {
  width: max-content;
}
#Home .butns button img {
  width: 30px;
}

nav {
  padding: 5px 40px;
  opacity: 1 !important;
  z-index: 10000;
}
@media (max-width: 1300px) {
  nav {
    padding: 5px 5px;
  }
}
@media (min-width: 992px) and (max-width: 1300px) {
  nav {
    padding: 5px 20px;
  }
}
nav {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  position: fixed;
  top: 0;
  right: initial;
  bottom: initial;
  left: 0;
  z-index: 1000;
  backdrop-filter: blur(5px);
  background: rgb(0, 0, 0);
  box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px;
  justify-content: space-between;
  transition: all 1s !important;
}
nav .navLogo a {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
nav .navLogo a img {
  width: 60px;
}
nav .navLogo a h2 {
  color: white;
  font-size: 25px;
  font-weight: 400;
}
@media (max-width: 1300px) {
  nav .navLogo a h2 {
    font-size: 17px;
  }
}
nav .navBtn {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  gap: 10px;
}
nav .navBtn img {
  width: 40px;
  cursor: pointer;
}
@media (max-width: 1300px) {
  nav .navBtn img {
    width: 35px;
  }
}

nav.noShow {
  transform: translateY(-100%);
}

.pop-up-nav {
  position: absolute;
  top: 0;
  right: initial;
  bottom: initial;
  left: 0;
  width: 100%;
  height: 100%;
}
.pop-up-nav.show {
  opacity: 1;
  z-index: 10000;
}
.pop-up-nav.show .pop-box-nav {
  transform: translateX(0);
  opacity: 1;
}
.pop-up-nav::-webkit-scrollbar {
  display: none;
  /* Chrome, Safari, Opera */
}
.pop-up-nav {
  opacity: 0;
  z-index: -1;
  transition-duration: 1s;
  backdrop-filter: blur(5px);
  background: rgba(0, 0, 0, 0.603);
  overflow: auto !important;
}
.pop-up-nav .pop-box-nav {
  position: absolute;
  top: 0;
  right: initial;
  bottom: initial;
  left: 0;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 350px;
  background-color: rgb(22, 22, 22);
  background-image: url("../imgs/bg.png");
  padding: 50px 5px;
  opacity: 0;
  transform: translateX(-100%);
  transition: all 0.5s 0.5s;
}
.pop-up-nav .pop-box-nav .logout {
  position: absolute;
  top: 10px;
  right: initial;
  bottom: initial;
  left: 0;
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  justify-content: flex-end;
}
.pop-up-nav .pop-box-nav .logout button {
  width: 70px;
  background-color: transparent;
  border: 0;
}
.pop-up-nav .pop-box-nav .title {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.pop-up-nav .pop-box-nav .title .titleHead {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
.pop-up-nav .pop-box-nav .title .titleHead h2 {
  margin-top: 0.6rem;
  color: white;
}
.pop-up-nav .pop-box-nav .imgLogo {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  width: 150px;
  overflow: hidden;
  border-radius: 100%;
  border: 2px dotted #e4c590;
  backdrop-filter: blur(5px);
  background: rgba(0, 0, 0, 0.603);
}
@media (max-width: 1300px) {
  .pop-up-nav .pop-box-nav .navLinks {
    display: flex !important;
  }
}
.pop-up-nav .pop-box-nav .navLinks ul {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.pop-up-nav .pop-box-nav .navLinks ul li {
  margin: 0;
}
.pop-up-nav .pop-box-nav .navLinks ul li:not(:last-child) {
  margin-bottom: 15px;
}
@media (max-width: 1300px) {
  .pop-up-nav .pop-box-nav .navLinks2 {
    display: flex !important;
  }
}
.pop-up-nav .pop-box-nav .navLinks2 ul li {
  margin-bottom: 0 !important;
}
.pop-up-nav .pop-box-nav .navLinks2 ul li:first-child {
  border-block: 0 !important;
}
.pop-up-nav .pop-box-nav .navLinks2 ul li {
  width: 70%;
  text-align: center;
}
.pop-up-nav .pop-box-nav .navLinks2 ul li::after, .pop-up-nav .pop-box-nav .navLinks2 ul li::before {
  display: none;
}
.pop-up-nav .pop-box-nav .navLinks2 ul li {
  border-block: 2px dashed #e4c590;
}
@media (max-width: 1300px) {
  .pop-up-nav .pop-box-nav .navLinks3 {
    display: flex !important;
  }
}

#BooksCat.active .column, #War.active .column, #Horror.active .column, #History.active .column, #Since.active .column {
  transform: translateY(0) !important;
  opacity: 1 !important;
}
#BooksCat, #War, #Horror, #History, #Since {
  background-image: url("../imgs/bg.png");
  background-color: rgb(0, 0, 0);
  position: relative;
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  background-attachment: fixed;
}
#BooksCat .container .title, #War .container .title, #Horror .container .title, #History .container .title, #Since .container .title {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
#BooksCat .container .title .titleHead, #War .container .title .titleHead, #Horror .container .title .titleHead, #History .container .title .titleHead, #Since .container .title .titleHead {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  color: white;
}
#BooksCat .container .row .column, #War .container .row .column, #Horror .container .row .column, #History .container .row .column, #Since .container .row .column {
  width: 300px;
  height: 350px;
  padding: 20px;
  margin: auto;
  transform: translateY(30px);
  opacity: 0;
  transition: all 1s;
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
#BooksCat .container .row .column .item, #War .container .row .column .item, #Horror .container .row .column .item, #History .container .row .column .item, #Since .container .row .column .item {
  width: 100%;
  height: 100%;
}
#BooksCat .container .row .column .item .box:hover .shape, #War .container .row .column .item .box:hover .shape, #Horror .container .row .column .item .box:hover .shape, #History .container .row .column .item .box:hover .shape, #Since .container .row .column .item .box:hover .shape {
  opacity: 1 !important;
}
#BooksCat .container .row .column .item .box:hover .bodyText, #War .container .row .column .item .box:hover .bodyText, #Horror .container .row .column .item .box:hover .bodyText, #History .container .row .column .item .box:hover .bodyText, #Since .container .row .column .item .box:hover .bodyText {
  padding-block: 20px;
}
#BooksCat .container .row .column .item .box.box2, #War .container .row .column .item .box.box2, #Horror .container .row .column .item .box.box2, #History .container .row .column .item .box.box2, #Since .container .row .column .item .box.box2 {
  background-image: url("../imgs/catBooks/war-zone-landscape-with-apocalyptic-destruction.jpg");
}
#BooksCat .container .row .column .item .box.box3, #War .container .row .column .item .box.box3, #Horror .container .row .column .item .box.box3, #History .container .row .column .item .box.box3, #Since .container .row .column .item .box.box3 {
  background-image: url("../imgs/catBooks/egyptian-hieroglyphs-wall.jpg");
}
#BooksCat .container .row .column .item .box.box4, #War .container .row .column .item .box.box4, #Horror .container .row .column .item .box.box4, #History .container .row .column .item .box.box4, #Since .container .row .column .item .box.box4 {
  background-image: url("../imgs/catBooks/3704171.jpg");
}
#BooksCat .container .row .column .item .box, #War .container .row .column .item .box, #Horror .container .row .column .item .box, #History .container .row .column .item .box, #Since .container .row .column .item .box {
  position: relative;
  width: 100%;
  height: 100%;
  cursor: pointer;
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/catBooks/halloween-wallpaper-with-zombie-hand.jpg");
  overflow: hidden;
  border-radius: 15px;
}
#BooksCat .container .row .column .item .box::before, #War .container .row .column .item .box::before, #Horror .container .row .column .item .box::before, #History .container .row .column .item .box::before, #Since .container .row .column .item .box::before {
  content: "";
  display: block;
  background: linear-gradient(0deg, rgba(0, 0, 0, 0.8941176471) 10%, transparent 100%);
  width: 100%;
  height: 100%;
  position: absolute;
  top: initial;
  right: initial;
  bottom: 0;
  left: 0;
}
#BooksCat .container .row .column .item .box .shape, #War .container .row .column .item .box .shape, #Horror .container .row .column .item .box .shape, #History .container .row .column .item .box .shape, #Since .container .row .column .item .box .shape {
  backdrop-filter: blur(2px);
  background: rgba(0, 0, 0, 0.326);
  opacity: 0;
  transition: all 0.5s;
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
  position: absolute;
  top: initial;
  right: initial;
  bottom: 0;
  left: 0;
}
#BooksCat .container .row .column .item .box .shape img, #War .container .row .column .item .box .shape img, #Horror .container .row .column .item .box .shape img, #History .container .row .column .item .box .shape img, #Since .container .row .column .item .box .shape img {
  width: 70px;
}
#BooksCat .container .row .column .item .box .bodyText, #War .container .row .column .item .box .bodyText, #Horror .container .row .column .item .box .bodyText, #History .container .row .column .item .box .bodyText, #Since .container .row .column .item .box .bodyText {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  position: absolute;
  top: initial;
  right: initial;
  bottom: 0px;
  left: 0;
  background-color: black;
  transition: all 0.5s !important;
  padding: 10px;
}
#BooksCat .container .row .column .item .box .bodyText h2, #War .container .row .column .item .box .bodyText h2, #Horror .container .row .column .item .box .bodyText h2, #History .container .row .column .item .box .bodyText h2, #Since .container .row .column .item .box .bodyText h2 {
  text-transform: uppercase;
  font-size: 25px;
}

div.loading {
  position: fixed;
  top: 0;
  right: initial;
  bottom: initial;
  left: 0;
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  opacity: 1;
  z-index: 20000;
  transition: all 2s;
  background-image: url("../imgs/bg.png");
  background-color: black;
}
div.loading .cudeLoading {
  position: relative;
  width: 150px;
  height: 150px;
}
div.loading .cudeLoading .loadinBorder {
  width: 100%;
  height: 100%;
  border: 2px solid #ffffff;
  border-radius: 100%;
  border-top-color: #e4c590;
  animation: animationRotate 1s infinite linear;
  position: relative;
}
div.loading .cudeLoading .loadingImg {
  position: absolute;
  top: 0;
  left: 0;
  padding: 10px;
}
div.loading .cudeLoading .loadingImg img {
  width: 100%;
}
div.loading .text {
  width: 100%;
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
div.loading .text .show {
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
div.loading .text .show span {
  font-size: 90px;
}
@media (max-width: 1300px) {
  div.loading .text .show span {
    font-size: 80px;
  }
}
@media (min-width: 992px) and (max-width: 1300px) {
  div.loading .text .show span {
    font-size: 90px;
  }
}
div.loading .text .show span {
  -webkit-text-stroke-width: 1px;
  -webkit-text-stroke-color: rgb(255, 255, 255);
}
div.loading .text .dance {
  position: absolute;
  display: flex;
  flex-direction: initial;
  justify-content: center;
  align-items: center;
}
div.loading .text .dance span:nth-of-type(1) {
  animation-delay: 0.2s;
}
div.loading .text .dance span:nth-of-type(2) {
  animation-delay: 0.4s;
}
div.loading .text .dance span:nth-of-type(3) {
  animation-delay: 0.6s;
}
div.loading .text .dance span:nth-of-type(4) {
  animation-delay: 0.8s;
}
div.loading .text .dance span:nth-of-type(5) {
  animation-delay: 1s;
}
div.loading .text .dance span:nth-of-type(6) {
  animation-delay: 1.2s;
}
div.loading .text .dance span {
  color: white;
  font-size: 90px;
}
@media (max-width: 1300px) {
  div.loading .text .dance span {
    font-size: 80px;
  }
}
@media (min-width: 992px) and (max-width: 1300px) {
  div.loading .text .dance span {
    font-size: 90px;
  }
}
div.loading .text .dance span {
  animation: Swap 1s infinite alternate-reverse;
}

div.loading.unshow {
  opacity: 0;
  z-index: -1;
}

#War .container .row .column {
  height: 520px !important;
  width: 350px !important;
}
#War .box1 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/war/Black White Simple Real Soldier Wattpad Book Cover.png") !important;
}
#War .box2 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/war/Brown Bold Action Movie Flyer.png") !important;
}
#War .box3 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/war/Brown Rusty Mystery Novel Book Cover .png") !important;
}
#War .box4 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/war/Green & Red Simple Mystery Thriller Story Book Cover.png") !important;
}
#War .bodyText {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-items: flex-start !important;
  backdrop-filter: blur(5px);
  background-color: rgba(0, 0, 0, 0.445) !important;
}
#War .bodyText p {
  color: white;
}
#War .bodyText span.priseUnit {
  color: #e4c590;
}

#Horror .container .row .column {
  height: 520px !important;
  width: 350px !important;
}
#Horror .box1 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/Horror/Black Thriller Ebook Cover Document.png") !important;
}
#Horror .box2 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/Horror/Red and Black Photo The Red House Book Cover .png") !important;
}
#Horror .box3 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/Horror/Red Black Illustrated Haunted Manor Horror Novel Book Cover.png") !important;
}
#Horror .box4 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/Horror/Teal and Black The Silence Wattpad Book Cover.png") !important;
}
#Horror .bodyText {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-items: flex-start !important;
  backdrop-filter: blur(5px);
  background-color: rgba(0, 0, 0, 0.445) !important;
}
#Horror .bodyText p {
  color: white;
}
#Horror .bodyText span.priseUnit {
  color: #e4c590;
}

#History .container .row .column {
  height: 520px !important;
  width: 350px !important;
}
#History .box1 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/history/Beige and Brown Rusty Vintage Style Mystery Novel Book Cover .png") !important;
}
#History .box2 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/history/Brown And Black Rusty Mystery Novel Book Cover.png") !important;
}
#History .box3 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/history/Brown Rusty Mystery Novel Book Cover.png") !important;
}
#History .box4 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/history/Brown Vintage Style Mystery Novel Book Cover.png") !important;
}
#History .bodyText {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-items: flex-start !important;
  backdrop-filter: blur(5px);
  background-color: rgba(0, 0, 0, 0.445) !important;
}
#History .bodyText p {
  color: white;
}
#History .bodyText span.priseUnit {
  color: #e4c590;
}

#Since .container .row .column {
  height: 520px !important;
  width: 350px !important;
}
#Since .box1 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/ScienceFiction/Astronaut Floating in Space Science Fiction Book Cover.png   ") !important;
}
#Since .box2 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/ScienceFiction/Blue and White Cartoon Illustrative Novel Story Book Cover.png") !important;
}
#Since .box3 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/ScienceFiction/Purple and White Modern Journey Wattpad Book Cover.png") !important;
}
#Since .box4 {
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  background-image: url("../imgs/ScienceFiction/Red and White Minimalist Warrior Book Wattpad Book Cover.png") !important;
}
#Since .bodyText {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  align-items: flex-start !important;
  backdrop-filter: blur(5px);
  background-color: rgba(0, 0, 0, 0.445) !important;
}
#Since .bodyText p {
  color: white;
}
#Since .bodyText span.priseUnit {
  color: #e4c590;
}

/*# sourceMappingURL=index.cs.map */
