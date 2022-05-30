import React from 'react'
import { Link } from 'react-router-dom'

const Login = () => {
  return (
    <div className='container mt-5' style={{width:'500px'}}>
      <div className="form-group">
        <h3 className='text-primary mb-5'>Login</h3>
        <div className="form-floating mb-3">
          <input type="email" className="form-control" id="floatingInput" placeholder="name@example.com"/>
            <label for="floatingInput">Email address</label>
        </div>
        <div className="form-floating">
          <input type="password" className="form-control" id="floatingPassword" placeholder="Password"/>
            <label for="floatingPassword">Password</label>
        </div>
        <button className='btn btn-primary mt-2 w-100'>Login</button>
        &nbsp; <span className='mr-2'>Don't have an account ?</span>&nbsp;<Link to="/regsiter">Regsiter</Link> here its free !!
      </div>
    </div>
  )
}

export default Login