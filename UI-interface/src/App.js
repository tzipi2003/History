import { BrowserRouter, Link, Route, Routes } from 'react-router-dom'
//pages
import Connect from "./Component/Connect";
import About from "./Component/About";
import Home from "./Component/Home";

function App() {
  return (
    <div className='App'>
      <BrowserRouter>
        <nav>
          <h1>Our Site Information</h1>
          <Link to="/"> Home</Link>
          <Link to="/About"> About</Link>
      
        </nav>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/About" element={<About />} />
         
        </Routes>
      </BrowserRouter>
      <Connect/>
    </div>
  );
}

export default App;
