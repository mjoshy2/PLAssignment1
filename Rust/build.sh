#!/bin/sh

cargo test

/bin/rm -rf target .gitignore Cargo.lock .git
