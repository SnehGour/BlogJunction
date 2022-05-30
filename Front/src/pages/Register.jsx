import React from 'react'
import { Link } from 'react-router-dom'

const Register = () => {
  return (
    <div className='container mt-5' style={{ width: '500px' }}>
      <div className="form-group">
        <h3 className='text-primary mb-5'>Register</h3>
        <div className="form-floating mb-3">
          <input type="text" className="form-control" id="username" placeholder="username" />
          <label for="username">Username</label>
        </div>
        <div className="form-floating mb-3">
          <input type="email" className="form-control" id="email" placeholder="name@example.com" />
          <label for="email">Email address</label>
        </div>
        <div className="form-floating">
          <input type="password" className="form-control" id="password" placeholder="Password" />
          <label for="password">Password</label>
        </div>
        <button className='btn btn-primary mt-2 w-100'>Register</button>
        &nbsp; <span className='mr-2'>Alredy have a account ?</span>&nbsp;<Link to="/login">Login</Link>
      </div>
    </div>
  )
}

export default Register